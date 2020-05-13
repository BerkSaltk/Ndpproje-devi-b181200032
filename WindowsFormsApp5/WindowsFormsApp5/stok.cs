using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{

        class stok            // sınıftaki public elemanlara değer atamak ve değerlerini okumak için get set metotları kullanıyorum.
        {  
            int _id;                   
            string _stokadi;
            string _stokmodeli;
            string _stokserino;
            string _stokadedi;
            int _stoktarihi;
            string _kayıtyapan;

            // Özellikler (Properties)
            public int Id          
            {
                get { return _id; }                // get return değeri gönderir böylelikle geri döndürmeye yarar.
                set { _id = value; }               // set değeri ayarlama işlemini yapar.
            }

            public string Stok_Adı
            { 
                get { return _stokadi; }           // get return değeri gönderir böylelikle geri döndürmeye yarar
                set { _stokadi = value; }          // set değeri ayarlama işlemini yapar.
        }

            public string Stok_Modeli
            {
                get { return _stokmodeli; }        // get return değeri gönderir böylelikle geri döndürmeye yarar
                set { _stokmodeli = value; }       // set değeri ayarlama işlemini yapar.
        }

            public string Stok_Seri_No
            {
                get { return _stokserino; }        // get return değeri gönderir böylelikle geri döndürmeye yarar
                set { _stokserino = value; }       // set değeri ayarlama işlemini yapar.
        }

            public string Stok_Adedi
            {
                get { return _stokadedi; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
                set { _stokadedi = value; }        // set değeri ayarlama işlemini yapar.
        }

            public int Stok_Tarihi
            {
                get { return _stoktarihi; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
                set { _stoktarihi = value; }        // set değeri ayarlama işlemini yapar.
        }
            public string Kayıt_Yapan
            {
                get { return _kayıtyapan; }         // get return değeri gönderir böylelikle geri döndürmeye yarar
                set { _kayıtyapan = value; }        // set değeri ayarlama işlemini yapar.
        }
        }
    }

