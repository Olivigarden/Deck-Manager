using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckManager
{
    public partial class DeckManager : Form
    {
        public DeckManager()
        {
            InitializeComponent();
        }

        private enum CardSide
        {
            Back,
            Front
        }

        private readonly string[] VALID_IMAGE_FILETYPES = { "jpg", "jpeg", "png" };
        private List<Card> _cards = new List<Card>();
        private Stack<Card> _deck = new Stack<Card>();
        private Stack<Card> _discardPile = new Stack<Card>();
        private bool _doubleSidedCards = false;

        private void newDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Open a folder containing the images for the deck";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _cards.Clear();
                    _deck.Clear();
                    _discardPile.Clear();
                    _doubleSidedCards = MessageBox.Show("Are the cards double-sided?  " +
                        "Files need to be named like card1.jpg, card1_back.jpg, etc.", 
                        "Confirmation", 
                        MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
                    var folder = "M:\\Pictures\\Card Decks\\Ankh Ma'at AI";//dialog.SelectedPath;
                    foreach (var filePath in Directory.GetFiles(folder))
                    {
                        if (VALID_IMAGE_FILETYPES.Contains(filePath.Split('.')[1]))
                        {
                            if (_doubleSidedCards)
                            {
                                // It'd be "fun" to make it so you could assign one generic back to all the cards.  Future Olivia, ball's in your court.
                                if (!filePath.Contains("_back"))
                                {
                                    var cardPathPieces = filePath.Split('.');
                                    _cards.Add(new Card(filePath, $"{cardPathPieces[0]}_back.{cardPathPieces[1]}"));
                                }
                            }
                            else
                            {
                                _cards.Add(new Card(filePath));
                            }
                        }
                    }

                    lblRemainingCards.Text = $"Cards left: {_cards.Count}";
                    if (!_doubleSidedCards)
                    {
                        HideBackJunk();
                    }

                    ShuffleDeckAndDiscard();
                    btnDeal.Enabled = true;
                    btnUndo.Enabled = true;
                }
            }
        }

        private void HideBackJunk()
        {
            // Could probably centre the front stuff but I'm drunk and lazy atm so that sounds like a feature request.
            lblBack.Visible = false;
            picBack.Visible = false;
        }

        private void ShuffleDeckAndDiscard()
        {
            // Need to construct a list of randomly-selected pulls from the deck that narrow after each pull to simulate cards being drawn.
            var rand = new Random();
            var cardIndices = new List<int>();
            // This ain't efficient, but I'm acknowledging that, so it's fine, right?
            for (var i = 0; i < _cards.Count; i++)
            {
                cardIndices.Add(i);
            }

            while (cardIndices.Count > 0)
            {
                var cardIndex = cardIndices[rand.Next(cardIndices.Count)];
                _deck.Push(_cards[cardIndex]);
                cardIndices.Remove(cardIndex);
            }
        }

        private void DrawCard()
        {
            var chosenCard = _deck.Pop();
            if (_deck.Count == 0)
            {
                ShuffleDeckAndDiscard();
            }
            _discardPile.Push(chosenCard);
            if (_doubleSidedCards)
            {
                var nextCard = _deck.Peek();
                picBack.ImageLocation = nextCard.Back;
            }
            picFront.ImageLocation = chosenCard.Front;
            lblRemainingCards.Text = $"Cards left: {_deck.Count}";
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            DrawCard();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Have to do this twice so that we actually show the previous card.  There's probably a better way of doing this, but once again; Future Olivia, your time to shine.
            _deck.Push(_discardPile.Pop());
            _deck.Push(_discardPile.Pop());
            DrawCard();
        }
    }
}
