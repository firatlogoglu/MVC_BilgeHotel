using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.CORE.Services
{
    public interface ICoreService<T> where T : Entity.CoreEntity
    {
        //Ekleme İşlemleri-------------------------------------------

        //Tek Olarak Ekleme
        void Add(T itme);

        //Liste Halinde Ekleme
        void AddList(List<T> item);
        //----------------------------------------------------------


        //Güncelleme İşlemi----------------------------------------
        void Update(T item);
        //---------------------------------------------------------


        //Kaldırma-Silme İşlemleri---------------------------------

        //Tekli Kaldırma
        void Remove(T item);

        //Hepsini Kaldırma
        void RemoveAll(Expression<Func<T, bool>> expression);
        //----------------------------------------------------------


        //Getirme İşlemleri-----------------------------------------

        //Tekli Olarak Getirme
        T GetByID(T ID);

        //TODO: 4.)  ID SONRA AYARLA

        //Varsayılanı/Kategori olarak Getirme
        T GetByDefault(Expression<Func<T, bool>> expression);

        //Akifleri Listeleme
        List<T> GetActive();

        List<T> GetGenelStatus(Expression<Func<T, bool>> expression);

        //Hepsini Listeleme
        List<T> GetAll();

        //Koşula Göre Getirme - Login İşlemi
        bool Any(Expression<Func<T, bool>> expression);

        //-----------------------------------------------------------------


        //Kadetme İşlemi----------------------------------------------------
        int Save();
    }
}
