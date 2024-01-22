using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.repositories;
using data.tables;
namespace data.uows
{
    public class BlogUnitOfWork
    {
        private BlogContext _context;

        public BlogUnitOfWork() {
            _context = new BlogContext();
        }
        private Repository<Blog> _blogRepository;
        private Repository<Post> _postRepository;
        private Repository<Krediler> _kredilerRepository;
        private Repository<Hava_Durumu> _Hava_DurumuRepository;
        private Repository<Sehirler> _SehirlerRepository;
        private Repository<Sözlük> _SözlükRepository;
        private Repository<Futbol_Puan_Durumu> _Futbol_Puan_DurumuRepository;
        private Repository<Steam_Oyun_Kütüphanesi> _Steam_Oyun_KütüphanesiRepository;
        private Repository<Filmler> _FilmlerRepository;


        public Repository<Krediler> kredilerRepository {
            get {
                if (_kredilerRepository == null) {
                    _kredilerRepository = new Repository<Krediler>(_context);
                }
                return _kredilerRepository;
            }
        }
        public Repository<Blog> blogRepository {
            get {
                if (_blogRepository == null) {
                    _blogRepository = new Repository<Blog>(_context);
                }
                return _blogRepository;
            }
        }
        public Repository<Post> postRepository {
            get {
                if (_postRepository == null) {
                    _postRepository = new Repository<Post>(_context);
                }
                return _postRepository;
            }
        }
        public Repository<Hava_Durumu> Hava_DurumuRepository {
            get {
                if (_Hava_DurumuRepository == null) {
                    _Hava_DurumuRepository = new Repository<Hava_Durumu>(_context);
                }       
                return _Hava_DurumuRepository;
            }
        }
        public Repository<Sehirler> SehirlerRepository {
            get {
                if (_SehirlerRepository == null) {
                    _SehirlerRepository = new Repository<Sehirler>(_context);
                }
                return _SehirlerRepository;
            }
        }
        public Repository<Sözlük> SözlükRepository {
            get {
                if (_SözlükRepository == null) {
                    _SözlükRepository = new Repository<Sözlük>(_context);
                }
                return _SözlükRepository;
            }
        }
        public Repository<Futbol_Puan_Durumu> Futbol_Puan_DurumuRepository {
            get {
                if (_Futbol_Puan_DurumuRepository == null) {
                    _Futbol_Puan_DurumuRepository = new Repository<Futbol_Puan_Durumu>(_context);
                }
                return _Futbol_Puan_DurumuRepository;
            }
        }
        public Repository<Steam_Oyun_Kütüphanesi> Steam_Oyun_KütüphanesiRepository {
            get {
                if (_Steam_Oyun_KütüphanesiRepository == null) {
                    _Steam_Oyun_KütüphanesiRepository = new Repository<Steam_Oyun_Kütüphanesi>(_context);
                }
                return _Steam_Oyun_KütüphanesiRepository;
            }
        }
        public Repository<Filmler> FilmlerRepository {
            get {
                if (_FilmlerRepository == null) {
                    _FilmlerRepository = new Repository<Filmler>(_context);
                }
                return _FilmlerRepository;
            }
        }
    }
}   