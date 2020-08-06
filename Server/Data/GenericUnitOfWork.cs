using Fishy_Model.Models;
using Server.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Data
{
    public class GenericUnitOfWork : IDisposable
    {
        private bool disposed = false;
        private FishyContext db = new FishyContext();
        private GenericRepository<ALBUM> albumRepository;
        private GenericRepository<COMMENT> commentRepository;
        private GenericRepository<DIALOG> dialogRepository;
        private GenericRepository<FISH> fishRepository;
        private GenericRepository<FRIEND> friendRepository;
        private GenericRepository<MESSAGE> messageRepository;
        private GenericRepository<NEWS> newsRepository;
        private GenericRepository<PHOTO> photoRepository;
        private GenericRepository<STATE_INSPECTION> inspectionRepository;
        private GenericRepository<USER> userRepository;
        public GenericRepository<ALBUM> Albums
        {
            get
            {
                if (albumRepository == null)
                    albumRepository = new GenericRepository<ALBUM>(db);
                return albumRepository;
            }
        }
        public GenericRepository<COMMENT> Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new GenericRepository<COMMENT>(db);
                return commentRepository;
            }
        }
        public GenericRepository<DIALOG> Dialogs
        {
            get
            {
                if (dialogRepository == null)
                    dialogRepository = new GenericRepository<DIALOG>(db);
                return dialogRepository;
            }
        }
        public GenericRepository<FISH> Fishes
        {
            get
            {
                if (fishRepository == null)
                    fishRepository = new GenericRepository<FISH>(db);
                return fishRepository;
            }
        }
        public GenericRepository<FRIEND> Friends
        {
            get
            {
                if (friendRepository == null)
                    friendRepository = new GenericRepository<FRIEND>(db);
                return friendRepository;
            }
        }
        public GenericRepository<MESSAGE> Messages
        {
            get
            {
                if (messageRepository == null)
                    messageRepository = new GenericRepository<MESSAGE>(db);
                return messageRepository;
            }
        }
        public GenericRepository<NEWS> News
        {
            get
            {
                if (newsRepository == null)
                    newsRepository = new GenericRepository<NEWS>(db);
                return newsRepository;
            }
        }
        public GenericRepository<PHOTO> Photos
        {
            get
            {
                if (photoRepository == null)
                    photoRepository = new GenericRepository<PHOTO>(db);
                return photoRepository;
            }
        }
        public GenericRepository<STATE_INSPECTION> StateInspections
        {
            get
            {
                if (inspectionRepository == null)
                    inspectionRepository = new GenericRepository<STATE_INSPECTION>(db);
                return inspectionRepository;
            }
        }
        public GenericRepository<USER> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new GenericRepository<USER>(db);
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
