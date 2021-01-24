using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;//Veri kaynağına yönelik açık bağlantı
using System.Data;//Verilerin bellek içi önbelleği
using System.Configuration;

namespace DATAACCESSLAYER
{
    class Baglanti
    {
        //veritabanı bağlantımızı açmak için bu yapıyı kullanıyoruz.
        OleDbConnection connection;//bağlantıyı connection stringi saglar
        
        public OleDbConnection baglanti
        {
            get
            {
                if (connection != null) //veri tabani baglantisi boş değil ise
                {
                    if (connection.State == ConnectionState.Closed)//veri kaynağıyla bağlantının geçerli durumda
                    {
                        connection.Open(); //veri tabanı baglantisini acar 
                    }
                    return connection;//degilse baglantiya geri doner
                }
                else
                {
                    connection = new OleDbConnection(Provider());
                    //Bağlantı dizesinin Provider()kod bloğuna giderek belirtilen OLE DB sağlayıcısının adını alır.
                    if (connection.State == ConnectionState.Closed)//veri kaynağıyla bağlantının geçerli durumda
                    {
                        connection.Open();//veri tabanı baglantisini acar
                    }
                    return connection;//degilse baglantiya geri doner
                }

            }

        }

        //App.config'den veritabanı adresimizi almak için bir bağlantı cümlesi oluşturuyoruz.
        private string Provider()
        {

            return Access.DATA_ACCESS;
            //DATAACCESSLAYER içerisinde Access.cs icerisine gönderir.
        }
    
    }
}
