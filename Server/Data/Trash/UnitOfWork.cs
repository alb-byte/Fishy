using Fishy_Model.Models;
using Server.Data.Repositories;
using System;

namespace Server.Data
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed = false;
        private FishyContext db = new FishyContext();
        private AlbumRepository albumRepository;
        private CommentRepository commentRepository;
        private DialogRepository dialogRepository;
        private FishRepository fishRepository;
        private FriendRepository friendRepository;
        private MessageRepository messageRepository;
        private NewsRepository newsRepository;
        private PhotoRepository photoRepository;
        private StateInspectionRepository inspectionRepository;
        private UserRepository userRepository;
        public AlbumRepository Albums
        {
            get
            {
                if (albumRepository == null)
                    albumRepository = new AlbumRepository(db);
                return albumRepository;
            }
        }
        public CommentRepository Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
            }
        }
        public DialogRepository Dialogs
        {
            get
            {
                if (dialogRepository == null)
                    dialogRepository = new DialogRepository(db);
                return dialogRepository;
            }
        }
        public FishRepository Fishes
        {
            get
            {
                if (fishRepository == null)
                    fishRepository = new FishRepository(db);
                return fishRepository;
            }
        }
        public FriendRepository Friends
        {
            get
            {
                if (friendRepository == null)
                    friendRepository = new FriendRepository(db);
                return friendRepository;
            }
        }
        public MessageRepository Messages
        {
            get
            {
                if (messageRepository == null)
                    messageRepository = new MessageRepository(db);
                return messageRepository;
            }
        }
        public NewsRepository News
        {
            get
            {
                if (newsRepository == null)
                    newsRepository = new NewsRepository(db);
                return newsRepository;
            }
        }
        public PhotoRepository Photos
        {
            get
            {
                if (photoRepository == null)
                    photoRepository = new PhotoRepository(db);
                return photoRepository;
            }
        }
        public StateInspectionRepository StateInspections
        {
            get
            {
                if (inspectionRepository == null)
                    inspectionRepository = new StateInspectionRepository(db);
                return inspectionRepository;
            }
        }
        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
