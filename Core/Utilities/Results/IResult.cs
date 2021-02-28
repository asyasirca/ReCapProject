using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç.unutmaa!!
    public interface IResult
    {
        bool Success { get; }//get sadece okunabilir demek
        //yapmaya çalıştığın ekleme işi başarılı:true
        //yapmaya çalıştığın ekleme işi başarısız:false
        string Message { get; } //Yapmaya çalıştığın ekleme işi mesela True yani ürün eklendi.
    }
}
