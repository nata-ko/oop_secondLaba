using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class GameAccount
    {
        private bool _isVip = false;
        public bool IsVip { get => _isVip ;
            set
            {
                _isVip = value;
            } 
        }

        private bool _isCheater = false;
        public bool IsCheater
        {
            get => _isCheater;
            set
            {
                _isCheater = value;
            }
        }
        private int _currentRating;
        private String _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
            }
        }
        public int CurrentRating
        {
            set
            {
                if(_currentRating <= 0)
                {
                    _currentRating = 1;
                }
                else
                {
                    _currentRating = value;
                }
                
            }

            get => _currentRating;
        }
        private readonly List<History> _gameAccountStatus = new List<History>();



        public GameAccount(string name)
        {
            _userName = name;
            _currentRating = new Random().Next(1, 20);
        }


        public  bool CheckRating( int gameRating)
        {
            return _currentRating - gameRating > 0;
        }


        public  void  GetExeption(Boolean checkRating)
        {
            if (!checkRating)
            {
                Console.WriteLine($"\t\t\tERROR! {_userName}'s rating is less than 0! UPDATED {_userName}'S RATING = 1");
            }
        }
        public string GetStatus()
            {
                var result = new System.Text.StringBuilder();
                result.AppendLine($"for current user - {_userName}\n");
                result.AppendLine("Game's ID\t\tPoints\tStatus\tRating\t\tOpponent\tOpponent's points\tOpponent's Status");
                foreach (var item in _gameAccountStatus)
                {
                    result.AppendLine($"{item.GameIdStr}\t\t{item.UserGameResultRating}\t{item.UserGameStatus}\t{item.MainUserRating}\t\t{item.OpponentUser.UserName}\t\t{item.OpponentGameResultRating}\t\t\t{item.OpponentGameStatus}");
                }
                return result.ToString();
            }


        // ------------------ Modifications for the second lab -------------------

        public virtual void WinGame(GameAccount opponent, BaseGame game)
        {
            _currentRating += game.GameRating;
            PlayedGameResult(this, opponent, game, GameResultStatus.win, _isVip, _isCheater);
        }

        public virtual void LooseGame(GameAccount opponent, BaseGame game)
        {
            GetExeption(CheckRating(game.GameRating));
            _currentRating = (CheckRating(game.GameRating)) ? _currentRating - game.GameRating : 1;
            PlayedGameResult(this, opponent, game, GameResultStatus.loose, _isVip, _isCheater);
        }

        public static void PlayedGameResult(GameAccount user, GameAccount opponent, BaseGame game, GameResultStatus grs, bool isVip, bool isCheater)
        {
            user._gameAccountStatus.Add(new History(user, opponent, game, grs, isVip, isCheater));
        }

    }    
}

