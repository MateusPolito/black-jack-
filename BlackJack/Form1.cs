using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private List<Card> playerCards;
        private List<Card> dealerCards;
        private int playerScore;
        private int dealerScore;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnhit.Enabled = false;
            btnstand.Enabled = false;
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            deck = new Deck();
            playerCards = new List<Card>();
            dealerCards = new List<Card>();
            playerScore = 0;
            dealerScore = 0;

            playerCards.Add(deck.DrawCard());
            playerCards.Add(deck.DrawCard());
            dealerCards.Add(deck.DrawCard());
            dealerCards.Add(deck.DrawCard());

            UpdateScores();
            UpdateUI();

            btndeal.Enabled = false;
            btnhit.Enabled = true;
            btnstand.Enabled = true;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            playerCards.Add(deck.DrawCard());
            UpdateScores();
            UpdateUI();

            if (playerScore > 21)
            {
                MessageBox.Show("Bust! You lose.");
                EndGame();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            while (dealerScore < 17)
            {
                dealerCards.Add(deck.DrawCard());
                UpdateScores();
                UpdateUI();
            }

            if (dealerScore > 21 || playerScore > dealerScore)
            {
                MessageBox.Show("You win!");
            }
            else if (dealerScore == playerScore)
            {
                MessageBox.Show("It's a tie!");
            }
            else
            {
                MessageBox.Show("Dealer wins!");
            }

            EndGame();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deck = new Deck();
            playerCards = new List<Card>();
            dealerCards = new List<Card>();
            playerScore = 0;
            dealerScore = 0;

            lbPlayerCards.Items.Clear();
            lbDealerCards.Items.Clear();

            lblPlayerScore.Text = "Player Score: 0";
            lblDealerScore.Text = "Dealer Score: 0";

            btndeal.Enabled = true;
            btnhit.Enabled = false;
            btnstand.Enabled = false;
        }

        private void UpdateScores()
        {
            playerScore = playerCards.Sum(c => c.Value);
            dealerScore = dealerCards.Sum(c => c.Value);
        }

        private void UpdateUI()
        {
            lbPlayerCards.Items.Clear();
            lbDealerCards.Items.Clear();

            foreach (var card in playerCards)
            {
                lbPlayerCards.Items.Add(card);
            }

            foreach (var card in dealerCards)
            {
                lbDealerCards.Items.Add(card);
            }

            lblPlayerScore.Text = $"Player Score: {playerScore}";
            lblDealerScore.Text = $"Dealer Score: {dealerScore}";
        }

        private void EndGame()
        {
            btndeal.Enabled = true;
            btnhit.Enabled = false;
            btnstand.Enabled = false;
        }

        private void lbDealerCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event handler can remain empty if not needed
        }
    }

    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suit)suit, value));
                }
            }
            random = new Random();
            Shuffle();
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(c => random.Next()).ToList();
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck.");
            }
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    public class Card
    {
        public Suit Suit { get; }
        public int Value { get; }

        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
}