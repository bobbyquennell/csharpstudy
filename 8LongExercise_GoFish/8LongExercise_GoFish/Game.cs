using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8LongExercise_GoFish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Value, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;
        private int roundOfGame = 0;
        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string opponent in opponentNames)
            {
                players.Add(new Player(opponent, random, textBoxOnForm));
            }
            books = new Dictionary<Value, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }
        private void Deal()
        {
            // This is where the game starts - this method's only called at the beginning
            // of the game. Shuffle the stock, deal five cards to each player, then use a 
            // foreach loop to call each player's PullOutBooks() method.
            stock.Shuffle();
            foreach(Player eachPlayer in players){
               for(int i = 0; i < 5; i++)
                   eachPlayer.TakeCard(stock.Deal());
            }
            foreach (Player eachPlayer in players)
            {
                PullOutBooks(eachPlayer);
            }
        }
        public bool PlayOneRound(int selectedPlayerCard){
            //Play  one round of the game. The parameter is the card the player selected
            //from his hand - get its value. Then go through all of the players and call 
            //each one's AskForACard() methods, starting with the human player(who's
            //at index zero in the Players list - make sure he asks for the selected
            // card's value). Then call PullOutBooks() - if it returns true, then the
            //player ran out of cards and needs to draw a new hand. After all the players
            //have gone, sort the human player's hand ( so it looks nice in the form).
            //Then check the stock to see if it's out of cards. If it is, reset the 
            //TextBox on the form to say, "The stock is out of cards. Game over!" and return
            //true. Otherwise, the game isn't over yet, so return false.
            roundOfGame++;
            this.textBoxOnForm.Text += "********" + " Round " + roundOfGame + " ********\r\n";
            Value value= players[0].Peek(selectedPlayerCard).Value;
            players[0].AskForACard(players,0, stock, value);
            foreach (Player player in players)
            {
                if(players.IndexOf(player) != 0)
                    player.AskForACard(players, players.IndexOf(player), stock);
                bool isRunOutofCards = PullOutBooks(player);
                if (isRunOutofCards)
                {
                    for (int i = 0; i < 5; i++)
                    {     
                        if (stock.Count > 0)
                            player.TakeCard(stock.Deal());
                    }
                }
            }
            players[0].SortHand();
            if (stock.Count == 0)
            {
                this.textBoxOnForm.Text = "The stock is out of cards. Game over!\r\n";
                return true;
            }
            else
                return false;
        }
        public bool PullOutBooks(Player player)
        {
            //Pull out a player's books. Return true if the player ran out of cards, otherwise
            //return false. Each book is added to the Books dictionary. A player runs out of 
            // cards when he's used all of his cards to make books-and he wins the game.
            List<Value> BooksOfAPlayer = (List<Value>)player.PullOutBooks();
            if (BooksOfAPlayer.Count > 0)
            {
                foreach (Value book in BooksOfAPlayer)
                {
                    books.Add(book, player);
                }
            }
            if (player.CardCount == 0)
                return true;
            else
                return false;
        }
        public string DescribeBooks(){
            // Return a long string that describes everyone's books by looking at the Books.
            //dictionary:" Joe has a book of sixes. (line break) Ed has a book of Aces."
            string Decription = "";
            foreach(Value value in books.Keys)
            {
                Decription += books[value].Name + " has a book of " + Card.Plural(value) + "\r\n";
            }
            return Decription;
        }
        public string GetWinnerName()
        {
            // This method is called at the end of the game. It uses its own dictionary
            // (Fictionary<string, int> winners) to keep track of how many books each player
            // ended up with in the books dictionary. First it uses a foreach loop
            // on books.Keys --foreach(Values value in books.Keys) -- to populate
            //its winners dictionary with the number of books each player ended up with.
            //Then it loops through that dictionary to find the largest number of books
            //any winner has. And finally it makes one last pass through winners to come
            //up with a list of winners in a string ("Joe and Ed"). If there's one winner,
            //it returns a string like this:" Ed with 3 books". Otherwise it returns a
            // string like this:"A tie between Joe and Bob with 2 books."
            string returnValue = "";
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Value value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name] += 1;
                else
                    winners.Add(books[value].Name, 1);          
            }
            List<string>trueWinner = new List<string>();
            foreach (string name in winners.Keys)
            {
                if (trueWinner.Count == 0)
                    trueWinner.Add(name);
                else
                {
                    if (winners[name] > winners[trueWinner[0]])
                    {
                        trueWinner.RemoveRange(0, trueWinner.Count);
                        trueWinner.Add(name);
                    }
                    else if (winners[name] == winners[trueWinner[0]])
                        trueWinner.Add(name);
                }

            }
            if (trueWinner.Count == 1)
               returnValue += trueWinner[0] + " with " +  winners[trueWinner[0]] + " books\r\n";
            else
                for(int i = 0;i < trueWinner.Count; i++)
                {
                    if (i == 0)
                        returnValue = trueWinner[0];
                    else

                        returnValue += " and " + trueWinner[i];
                }
            returnValue += " with " + winners[trueWinner[0]] + " books\r\n";

            return returnValue;
        }
        public IEnumerable<string> GetPlayerCardNames() {
            return players[0].GetCardNames();
        }
        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }

            description += "The stock has " + stock.Count + " cards Left.\r\n";
            return description;
        }

    }
}
