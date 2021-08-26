using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Arcade.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Arcade.Controllers
{
    public class ArcadeController : Controller
    {
        private Arcade_Context _context;
        private readonly IHostingEnvironment hostingEnvironment;
        public ArcadeController(Arcade_Context context, IHostingEnvironment environment)
        {
            _context = context;
            hostingEnvironment = environment;
        }

        //initializations
        public void Initialize(User user)//setting variables and viewbags for a registered user
        {
            //variables
            var hobbies = _context.Games.Count();
            //viewbags
            ViewBag.UserFirstName = user.FirstName;
            ViewBag.UserLastName = user.LastName;
            ViewBag.ThisUser = user;
            ViewBag.AllHobbies = _context.Games.Include(s => s.Authors);
            ViewBag.AllHobbiesCount = hobbies;
            //variables
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            var onthelist = _context.Games.Include(a => a.Authors).Where(a => a.UserId == userInDb.userId);
            var returning = _context.Associations.Any(r => r.UserId == userInDb.userId);
            var hobbyists = _context.Associations.Include(a => a.User).Include(b => b.Game);
            var hobbyistsCount = hobbyists.Count();
            var games = _context.Games.Count();
            //viewbags/viewdata

            ViewBag.Count = hobbyistsCount;
            ViewBag.Hobbyists = hobbyists;
            ViewData["ThisUser"] = userInDb;
            ViewData["UserFirstName"] = userInDb.FirstName;
            ViewData["UserLastName"] = userInDb.LastName;
            ViewData["AllGames"] = _context.Games.Include(s => s.Authors);
            ViewData["AllGamesCount"] = games;
            ViewData["Count"] = hobbyistsCount;
            ViewData["Hobbyists"] = hobbyists;
            ViewData["context"] = _context;
            ViewData["returning"] = returning;
            ViewData["AllLikes"] = _context.Games.Include(x => x.Likes);
        }
        public void Initialize_L(LoginUser user)//setting variables and viewbags for a returning user
        {
            //variables
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            var onthelist = _context.Games.Include(a => a.Authors).Where(a => a.UserId == userInDb.userId);
            var returning = _context.Associations.Any(r => r.UserId == userInDb.userId);
            var hobbyists = _context.Associations.Include(a => a.User).Include(b => b.Game);
            var hobbyistsCount = hobbyists.Count();
            var games = _context.Games.Count();

            //viewbags/viewdata
            ViewData["ThisUser"] = userInDb;
            ViewData["UserFirstName"] = userInDb.FirstName;
            ViewData["UserLastName"] = userInDb.LastName;
            ViewData["AllGames"] = _context.Games.Include(s => s.Authors);
            ViewData["AllGamesCount"] = games;
            ViewData["Count"] = hobbyistsCount;
            ViewData["Hobbyists"] = hobbyists;
            ViewData["context"] = _context;
            ViewData["returning"] = returning;
            ViewData["AllLikes"] = _context.Games.Include(x => x.Likes);

            Console.WriteLine(returning);
        }
        public void Initialize_G(Game game, int userId)//varaibles and viewbags for hobbies
        {
            //variables
            //ViewBag.CommentsCount = game.Comments.Count();
            //ViewData["AllComments"] = game.Comments;
            var players = _context.Associations.Include(a => a.User).Include(b => b.Game).Where(b => b.GameId == game.GameId);
            var playersCount = players.Count();
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            var _game = _context.Games.FirstOrDefault(b => b.GameId == game.GameId);
            //viewbags
            ViewBag.ThisUser = userInDb;
            ViewBag.Game = _game;
            ViewBag.Count = playersCount + 1;//assuming here that the creator of the hobby also partakes in it.
            ViewBag.Players = players;
        }
        public void Initialize_Assoc(int gameId, int userId)//varaibles and viewbags for associations
        {
            //variables

            var _game = _context.Games.FirstOrDefault(b => b.GameId == gameId);
            var players = _context.Associations.Include(a => a.User).Include(b => b.Game).Where(b => b.GameId == gameId);
            var playersCount = players.Count();
            //var comments = _context.Comments.Include(a => a.User).Include(b => b.Game).Where(b => b.GameId == gameId);
            //var commentsCount = comments.Count();
            var total = _context.Games.Count();
            var totalLikes = _context.Associations.Count();
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            //viewbags
            ViewData["ThisUser"] = userInDb;
            ViewData["UserFirstName"] = userInDb.FirstName;
            ViewData["UserLastName"] = userInDb.LastName;
            ViewData["Game"] = _game;
            ViewData["AllGames"] = _context.Games;
            ViewData["AllGamesCount"] = total;
            ViewData["AllLikesCount"] = totalLikes;
            ViewData["PlayersCount"] = playersCount;
            ViewData["Players"] = players;
            //ViewData["CommentsCount"] = commentsCount;
            //ViewData["Comments"] = comments;
            ViewData["AllGames"] = _context.Games.Include(x => x.Authors);
            ViewData["AllLikes"] = _context.Games.Include(x => x.Likes);
        }
        public void Initialize_Com(int gameId, int userId, Association com)//varaibles and viewbags for associations
        {
            //variables
            var _game = _context.Games.FirstOrDefault(b => b.GameId == gameId);
            var players = _context.Associations.Include(a => a.User).Include(b => b.Game).Where(b => b.GameId == gameId);
            var playersCount = players.Count();
            //var comments = _context.Comments.Include(a => a.User).Include(b => b.Game).Where(b => b.GameId == gameId);
            //var commentsCount = comments.Count();
            var total = _context.Games.Count();
            var totalLikes = _context.Associations.Count();
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            //viewbags
            ViewData["ThisUser"] = userInDb;
            //ViewData["UserFirstName"] = userInDb.FirstName;
            //ViewData["UserLastName"] = userInDb.LastName;
            ViewData["Game"] = _game;
            ViewData["AllGames"] = _context.Games;
            ViewData["AllGamesCount"] = total;
            ViewData["AllLikesCount"] = totalLikes;
            ViewData["PlayersCount"] = playersCount;
            ViewData["Players"] = players;
            //ViewData["CommentsCount"] = commentsCount;
            //ViewData["Comments"] = comments;
            ViewData["AllGames"] = _context.Games.Include(x => x.Authors);
            ViewData["AllLikes"] = _context.Games.Include(x => x.Likes);
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult Register(User user, LoginUser user_)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("Username", "Username already registered");
                    return View("Index");//going back to start
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Add(user);
                _context.SaveChanges();
                Initialize(user);
                Initialize_L(user_);
                return View("UserDashboard");
            }
            else
            {
                // something went wrong
                return View("Index");
            }
        }
        [HttpPost("login/user")]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Email not in Database");
                    return View("Index");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);
                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Index");
                }
                Initialize_L(user);
                return View("UserDashboard");
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }


        [HttpGet("userdashboard/{userId}")]
        public IActionResult UserDashboard(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.Email);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Email not found");
                    return View();
                }
            }
            return View("Unauthorized");
        }
        [HttpGet("/Game/{userId}")]
        public IActionResult Game(int userId)
        {
            var ThisUser = _context.Users.FirstOrDefault(b => b.userId == userId);
            ViewBag.ThisUser = ThisUser;
            return View();
        }

        [HttpPost("creategame")]
        public IActionResult CreateGame(Game game, int userId)
        {
            Initialize_G(game, userId);//initializations
            var ThisUser = _context.Users.FirstOrDefault(b => b.userId == userId);
            var img = game.Image;
            ViewBag.ThisUser = ThisUser;

            ViewBag.AllC = _context.Comments.Include(s => s.Authors).Where(a => a.GameId == game.GameId);
            if (_context.Games.Any(u => u.Title == game.Title))//unique game validation
            {
                ModelState.AddModelError("Title", "Game Name already exists.");
                return View("Game");//going back to start
            }
            if (ModelState.IsValid)
            {
                //geting image
                if (game.Image != null)
                {

                    var imgName = Path.GetFileName(game.Image.FileName);
                    var uniqueFileName = GetUniqueFileName(game.Image.FileName);
                    var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    game.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                    game.Imagename = uniqueFileName;
                    Console.WriteLine("Image Saved!");
                    //to do : Save uniqueFileName  to your db table   
                }

                //adding game
                Console.WriteLine(game.Title);
                _context.Add(game);
                _context.SaveChanges();
                ViewBag.Game = game;
                AddEnthusiast(game.GameId, userId);//adding creator to enthusiast pool.
                return View("Success");
            }
            else
            {
                //something went wrong, return a view to maintain model state
                return View("Game");
            }
        }
        [HttpPost("success")]
        public IActionResult Success()
        {
            return View();
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
        [HttpPost("comment/{userId}/{gameId}")]
        public IActionResult CreateComment(Game game, int userId, int gameId)
        {
            //Association model = _context.Comments.FirstOrDefault(h => h.GameId == gameId);
            Initialize_G(game, userId);
            var prevComments = game.Comment;
            var ThisUser = _context.Users.FirstOrDefault(b => b.userId == userId);
            ViewBag.ThisUser = ThisUser;
            var commentlist = new List<String>();
            var content = game.Comment;
            var list = game.Comments;
            //attempt
            Comment r = new Comment();
            r.comment = content;
            r.name = ThisUser.FirstName;
            r.UserId = userId;
            r.GameId = gameId;
            commentlist.Add(game.Comment);
            _context.Add(r);
            _context.SaveChanges();
            ViewBag.AllC = _context.Comments.Include(s => s.Authors).Where(a => a.GameId == gameId);
            ViewData["Comment"] = content;
            //list.Add(content);

            Console.WriteLine(content);
            Console.WriteLine(commentlist.LastOrDefault());
            //game.Comments.Add(game.Comments.Last());
            _context.SaveChanges();
            return View("ViewGame");

        }
        [HttpGet("{gameId}/{userId}/edit")]
        public IActionResult Edit(int gameId, Game game, int userId)//editing previous entry
        {
            var ThisUser = _context.Users.FirstOrDefault(b => b.userId == userId);
            ViewBag.ThisUser = ThisUser;
            Initialize_G(game, userId);
            Console.WriteLine("edit");
            Game model = _context.Games.FirstOrDefault(h => h.GameId == gameId);
            if (model == null)
                return RedirectToAction("Index");
            return View(model);
        }
        [HttpPost("{gameId}/{userId}/update")]
        public IActionResult Update(Game game, int gameId, int userId)//similar to edit
        {
            var ThisUser = _context.Users.FirstOrDefault(b => b.userId == userId);
            ViewBag.ThisUser = ThisUser;
            Initialize_G(game, userId);

            Game gameUpdate = _context.Games.FirstOrDefault(h => h.GameId == gameId);
            User userUpdate = _context.Users.FirstOrDefault(h => h.userId == userId);
            if (ModelState.IsValid)
            {
                Console.WriteLine("valid model state");
                gameUpdate.Title = game.Title;
                gameUpdate.Description = game.Description;
                if (game.Imagename != null)
                {
                    gameUpdate.Imagename = game.Imagename;
                }
                gameUpdate.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("DashBoardRedirect");
            }
            return View("Edit", game);
        }

        [HttpGet("/dashboardredirect/{userId}")]
        public IActionResult DashBoardRedirect(int gameId, int userId)
        {

            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            Initialize_Assoc(gameId, userId);
            return View("UserDashboard", userInDb);
        }
        [HttpGet("viewgame/{gameId}/{userId}")]
        public IActionResult ViewGame(int gameId, int userId)
        {
            ViewBag.AllC = _context.Comments.Include(s => s.Authors).Where(a => a.GameId == gameId);
            ViewBag.CommentsCount = _context.Comments.Count();
            ViewBag.AllComments = _context.Games.Include(x => x.Comments);
            Initialize_Assoc(gameId, userId);
            return View();
        }


        [HttpGet("game/{gameId}/{userId}/{status}")]
        public IActionResult RSVP(int gameId, int userId, string status, Game game, User user, Comment comment)
        {
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            var game_ = _context.Games.FirstOrDefault(b => b.GameId == gameId);
            var userInList = _context.Games.Any(u => u.Authors == game.Authors);
            var authors = _context.Associations.Include(a => a.User).Include(b => b.Game).Where(b => b.GameId == gameId);
            var likes = _context.Likes.Include(a => a.User).Include(b => b.Game).Where(a => a.UserId == userId);
            ViewBag.AllC = _context.Comments.Include(s => s.Authors).Where(a => a.GameId == gameId);

            Initialize_Assoc(gameId, userId);
            if (userInDb == null)
                return RedirectToAction("Index");

            //redirects if the game does not exist
            if (!_context.Games.Any(w => w.GameId == gameId))
                return RedirectToAction("Index", "Game");

            if (status == "add")
                if (authors.Any(u => u.UserId == user.userId))
                {
                    //ModelState.AddModelError("Username", "Username already registered");
                    Console.WriteLine("Already liked this game");
                    return View("ViewGame");//going back to start
                }
                else
                    AddEnthusiast(gameId, userId);
            else if (status == "delete")
            {
                //Removing the game from the database
                _context.Games.Remove(game_);
                _context.SaveChanges();
            }
            else if (status == "edit")
            {
                //Editing the game
                return View("Edit");
                //_context.SaveChanges();
            }
            else if (status == "like")
            {
                if (likes.Any(u => u.UserId == user.userId))
                {
                    //ModelState.AddModelError("Username", "Username already registered");
                    Console.WriteLine("Already liked this game");
                    Console.WriteLine(likes);
                    return View("ViewGame");//going back to start
                }
                else
                    Like(gameId, userId);
            }
            else if (status == "comment")
            {
                Console.WriteLine("Comment added");
                ViewBag.Comment = comment;
                AddComment(gameId, userId);
            }

            else
                //Removing the (association) from the database
                RemoveEnthusiast(gameId, userId);

            return View("UserDashboard", userInDb);
        }
        private void AddEnthusiast(int gameId, int userId)
        {
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            Association newEnjoyer = new Association()
            {
                GameId = gameId,
                UserId = userInDb.userId
            };
            _context.Associations.Add(newEnjoyer);
            _context.SaveChanges();
        }
        private void Like(int gameId, int userId)
        {
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            Association newLike = new Association()
            {
                GameId = gameId,
                UserId = userInDb.userId
            };
            _context.Likes.Add(newLike);
            _context.SaveChanges();
        }
        private void AddComment(int gameId, int userId)
        {
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            Comment newComment = new Comment()
            {
                GameId = gameId,
                UserId = userInDb.userId
            };
            _context.Comments.Add(newComment);
            _context.SaveChanges();
        }
        private void RemoveEnthusiast(int gameId, int userId)
        {
            //yes, this fucntion works. the association must be removed
            var userInDb = _context.Users.FirstOrDefault(b => b.userId == userId);
            // query for response
            Association enthusiast = _context.Associations.FirstOrDefault(r => r.UserId == userInDb.userId && r.GameId == gameId);

            if (enthusiast != null)
            {
                _context.Associations.Remove(enthusiast);
                _context.SaveChanges();
            }

        }
    }
}
