using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   //generic constraint generic kısıt
    //class referans tip olabilir demek yani int olamaz. 
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtreleme ile veri getiresin diye
        T Get(Expression<Func<T, bool>> filter);//filtre vermemişse tüm datayı istiyor demek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        // bu koda ihtiyacımız kalmadı(Expression<Func<T,bool>> filter=null) sayesinde
        //List<T> GetAllByCategory(int categoryId);
    }
}
