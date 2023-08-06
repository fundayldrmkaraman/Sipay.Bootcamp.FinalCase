# Sipay.Bootcamp.FinalCase

# Site Yönetimi Web API
Bu proje, dairelerin aidat ve faturalarının yönetimini sağlayan bir web API'dir. API, iki tip kullanıcıya sahiptir: Admin ve Normal Kullanıcı.

## Başlarken
Projede yer alan kavramların özet olarak bilgilendirmesi maddeler halinde verilmiştir.

API (Application Programming Interface); yazılım uygulamalarının birbirleriyle iletişim kurmasını sağlayan bir arayüzdür. API, farklı yazılım bileşenlerinin (uygulamalar, kütüphaneler, işletim sistemleri vb.) birbirleriyle etkileşime geçmesini ve veri alışverişi yapmasını sağlar.
API'ler, belirli bir hizmet veya platformun işlevselliğine erişim sağlar. Bu sayede uygulama geliştiricileri, başka bir yazılımın işlevselliğini kullanabilir ve kendi uygulamalarında bu işlevselliği entegre edebilir. Örneğin, bir hava durumu uygulaması, hava durumu bilgilerini sağlamak için bir hava durumu API'sini kullanabilir.
API'ler, yazılım geliştirme sürecini hızlandırmaya ve kod tekrarını önlemeye yardımcı olur. Aynı zamanda farklı platformların birbiriyle uyumlu çalışmasını ve entegrasyonunu sağlayarak uygulamalar arasında veri paylaşımını kolaylaştırır.

Entity; genel anlamda varlıkları, nesneleri veya var olan şeyleri ifade eder. Farklı bağlamlarda kullanıldığında anlamı değişebilir. İşte bazı yaygın kullanımları:

1.	Programlama ve Veritabanları: Yazılım geliştirme ve veritabanı kavramlarında "entity," veri tabanındaki bir varlığı temsil eden, belirli bir amaçla veri saklamak için kullanılan bir yapıdır. Veri tabanı tablolarındaki her satır, bir varlık (entity) örneğini temsil eder.
2.	Yapay Zeka ve Doğal Dil İşleme: Yapay zeka ve doğal dil işleme alanlarında, "entity" terimi, belirli bir tür veya sınıfa ait nesneleri ifade eder. Örneğin, bir metindeki kişilerin, yerlerin, tarihlerin veya diğer tanımlanabilir nesnelerin çıkarılması ve anlamlandırılması "entity extraction" olarak adlandırılır.
3.	Genel Dil Kullanımı: Günlük dilde, "entity" daha geniş bir kapsamda, varolan herhangi bir şeyi ifade edebilir. Herhangi bir varlık, nesne veya maddeyi kastetmek için kullanılabilir.

Servis; genel anlamda bir hizmeti, işlevi veya kaynağı temsil eden ve kullanıcılara belirli bir amaç için erişim sağlayan bir kavramdır. Servis terimi farklı bağlamlarda kullanılabilir:

1.	Teknoloji ve Bilgisayar Programlama: Bir yazılım uygulamasında, bir servis, belirli bir işlevi yerine getiren ve başka uygulamalar veya bileşenlerle etkileşime geçebilen bir parçadır. Bu, API (Application Programming Interface) yoluyla gerçekleştirilebilir ve diğer uygulamalara veri sağlamak veya işlemleri gerçekleştirmek için kullanılabilir.
2.	Web Hizmetleri: Web hizmetleri, internet üzerindeki belirli bir işlevi yerine getiren ve çeşitli platformlar arasında veri alışverişine izin veren yazılım bileşenleridir. Örneğin, ödeme işlemleri sağlayan bir web servisi, farklı e-ticaret siteleri tarafından kullanılabilir.
3.	İşletmelerde Hizmetler: İşletme bağlamında, bir servis, müşterilere sunulan belirli bir hizmeti ifade eder. Örneğin, bir otelde konaklama hizmeti, bir restoranda yemek hizmeti, bir bankada finansal hizmetler servisi gibi.
4.	Genel Kullanım: Genel olarak, "servis" terimi, herhangi bir hizmet, hizmet veya işlevi belirtmek için kullanılabilir. Bu, teknoloji dışındaki çeşitli alanlarda kullanılabilir.
 
JWT (JSON Web Token); JSON formatında yapılandırılmış ve dijital olarak imzalanmış bir veri yapısıdır. Özellikle, iki taraf arasında güvenli bir şekilde bilgi alışverişi yapmak için kullanılan bir kimlik doğrulama ve yetkilendirme yöntemidir. JWT, verileri taşımak ve doğrulamak için açık ve güvenli bir yöntem sunar.
JWT, üç temel bölümden oluşur:

1.	Header (Başlık): JWT'nin algoritma ve token türü gibi bilgileri içeren JSON nesnesidir. Bu bölüm, JWT'nin hangi algoritma ile imzalandığını ve hangi anahtarın kullanılacağını belirler.
2.	Payload (İçerik): JWT içerisinde taşınacak olan verilerin kendisi yer alır. Bu bölümde, tokenın sahibiyle ilgili bilgiler, yetkiler (claims) veya diğer kullanıcıya özgü veriler bulunabilir. Payload, şifrelenmemiştir ve açık bir şekilde okunabilir. Ancak, hassas bilgilerin burada saklanmaması ve tokenun doğrulanmasını etkileyecek bilgilerin doğrulanması gereklidir.
3.	Signature (İmza): JWT'nin doğrulanabilirliğini sağlamak için kullanılan bölümdür. İmza, Header ve Payload bölümlerini algoritmayla işleyerek oluşturulur. Alıcı, bu imza sayesinde tokenin geçerliliğini doğrular.

JWT, özellikle modern web uygulamalarında kimlik doğrulama ve yetkilendirme için kullanılır. Kullanıcılar bir kez giriş yaptıktan sonra, sunucu JWT'yi oluşturur ve kullanıcıya verir. Kullanıcı bu tokenı her istekle birlikte sunucuya gönderir ve sunucu da bu tokenı doğrularak kullanıcının kimliğini belirler ve yetkilerini kontrol eder.
JWT'nin avantajları, verilerin taşınması ve doğrulanmasının tek bir kompakt paket içinde gerçekleştirilmesidir. Ayrıca, sunucu tarafında tokenların saklanması yerine, tokenları kullanıcı tarafında saklayarak ölçeklenebilirlik sağlamasıdır. Ancak, güvenlik açısından, hassas bilgilerin içerikte bulunmaması ve tokenlar için uygun süreler belirlenerek düzenli olarak yenilenmesi gereklidir.

## Kurulum
1.	Bu depoyu klonlayın veya ZIP dosyası olarak indirin.
2.	Visual Studio kullanıyorsanız, SiteYonetimi.sln dosyasını açın ve projeyi derleyin.
Visual Studio Code kullanıyorsanız, projenin kök klasöründe terminali açın ve aşağıdaki komutu çalıştırın:
bashCopy code
dotnet build 
3.	Veritabanı bağlantısını ayarlamak için appsettings.json dosyasında SQL Server bağlantı dizesini güncelleyin:
jsonCopy code
"ConnectionStrings": { "DefaultConnection": "Your_SQL_Server_Connection_String" } 
4.	Veritabanını oluşturmak için aşağıdaki komutu çalıştırın:
bashCopy code
dotnet ef database update 
5.	Proje çalıştırmak için:
bashCopy code
dotnet run 
6.	Web API, https://localhost:5001 adresinde çalışmaya başlayacaktır.

## API Endpoints
Bu API, kullanıcılara belirli işlemleri gerçekleştirmek için bir dizi HTTP endpoint sağlar.

### Authentication
•	POST /api/auth/login: Kullanıcı girişi için kullanılır. Kullanıcı adı ve şifre ile istek göndererek JWT token alabilirsiniz.
### Admin İşlemleri
•	GET /api/admin/users: Tüm kullanıcıları listeler.
•	GET /api/admin/users/{id}: Belirli bir kullanıcıyı ID'ye göre getirir.
•	POST /api/admin/users: Yeni kullanıcı ekler.
•	PUT /api/admin/users/{id}: Belirli bir kullanıcıyı günceller.
•	DELETE /api/admin/users/{id}: Belirli bir kullanıcıyı siler.
### Normal Kullanıcı İşlemleri
•	GET /api/user/bills: Kullanıcının faturalarını listeler.
•	GET /api/user/bills/{id}: Belirli bir faturayı ID'ye göre getirir.
•	POST /api/user/bills/{id}/pay: Belirli bir faturayı öder.
•	POST /api/user/messages: Yöneticiye mesaj gönderir.
## Yetkilendirme ve Güvenlik
API, JWT (JSON Web Token) ile yetkilendirme sağlar. Kullanıcı giriş yaptığında bir JWT token alır ve bu token'ı Authorization başlığında kullanır.
Normal kullanıcılar sadece kendi faturalarını görüntüleyebilir ve ödeyebilir, mesaj gönderebilir. Admin kullanıcıları ise tüm kullanıcıları yönetebilir, fatura bilgilerini ekleyebilir ve düzenleyebilir.
Yetkilendirme için Admin ve User rolleri belirlenir. JWT, kullanıcı adı ve rolleri içeren bir payload ile imzalanır ve bu sayede API içindeki istekleri yetkilendirir.
## Veritabanı Modeli
Proje, aşağıdaki tablolardan oluşan bir SQL Server veritabanı kullanır:
•	Apartment: Daire bilgilerini tutar.
•	User: Kullanıcı bilgilerini tutar.
•	Bill: Fatura bilgilerini tutar.
•	Message: Kullanıcılar arasında mesajlaşma için kullanılır.
Veritabanı şeması ve ilişkileri DbContext sınıfında yapılandırılmıştır.
## Projenin Kullanımı
### Proje Kurulumu
1.	Öncelikle projeyi GitHub'dan indirin veya klonlayın. ZIP dosyası olarak indirirseniz, dosyaları çıkartın.
2.	Projeyi bir IDE (Integrated Development Environment) olarak Visual Studio veya Visual Studio Code ile açın.
3.	appsettings.json dosyasında SQL Server bağlantı dizesini güncelleyin. Bu, projenin veritabanıyla iletişim kuracağı bağlantıdır.
4.	Projeyi derleyin ve çalıştırın. API, https://localhost:5001 adresinde çalışmaya başlayacaktır.
### Admin Kullanıcı Girişi
1.	API'ye erişim için bir JWT (JSON Web Token) token'ına ihtiyacınız olacak. /api/auth/login endpointine POST isteği göndererek giriş yapabilirsiniz.
2.	Örnek giriş isteği:
bashCopy code
POST https://localhost:5001/api/auth/login Content-Type: application/json { "username": "admin@example.com", "password": "admin123" } 
3.	Başarılı bir giriş sonucunda JWT token'ını alacaksınız.
### Admin İşlemleri
1.	Authorization başlığında alınan JWT token'ını kullanarak admin işlemlerini gerçekleştirebilirsiniz.
2.	Kullanıcıları listelemek için: GET https://localhost:5001/api/admin/users
bashCopy code
GET https://localhost:5001/api/admin/users Authorization: Bearer {your_jwt_token} 
3.	Yeni bir kullanıcı eklemek için: POST https://localhost:5001/api/admin/users
bashCopy code
POST https://localhost:5001/api/admin/users Authorization: Bearer {your_jwt_token} Content-Type: application/json { "username": "newuser@example.com", "password": "newuser123", "role": "User" } 
4.	Kullanıcıları güncellemek için: PUT https://localhost:5001/api/admin/users/{id}
bashCopy code
PUT https://localhost:5001/api/admin/users/1 Authorization: Bearer {your_jwt_token} Content-Type: application/json { "username": "updateduser@example.com", "password": "updateduser123", "role": "Admin" } 
5.	Kullanıcıları silmek için: DELETE https://localhost:5001/api/admin/users/{id}
bashCopy code
DELETE https://localhost:5001/api/admin/users/2 Authorization: Bearer {your_jwt_token} 
### Normal Kullanıcı İşlemleri
1.	Normal kullanıcı girişi için de /api/auth/login endpointini kullanabilirsiniz.
2.	Başarılı bir giriş sonucunda yeni bir JWT token'ı alacaksınız.
3.	JWT token'ını kullanarak normal kullanıcı işlemlerini gerçekleştirebilirsiniz.
4.	Faturaları listelemek için: GET https://localhost:5001/api/user/bills
sqlCopy code
GET https://localhost:5001/api/user/bills Authorization: Bearer {your_jwt_token} 
5.	Bir faturayı ödemek için: POST https://localhost:5001/api/user/bills/{id}/pay
bashCopy code
POST https://localhost:5001/api/user/bills/1/pay Authorization: Bearer {your_jwt_token} 
6.	Mesaj göndermek için: POST https://localhost:5001/api/user/messages
bashCopy code
POST https://localhost:5001/api/user/messages Authorization: Bearer {your_jwt_token} Content-Type: application/json { "recipient": "admin@example.com", "message": "Merhaba! Bu bir test mesajıdır." } 
#### Güvenlik
 •	API, JWT ile yetkilendirme sağlar. Admin ve User rolleri, JWT içinde taşınan payload ile belirlenir.
 •	Normal kullanıcılar sadece kendi faturalarını ve mesajlarını görüntüleyebilir ve ödeyebilir.
 •	Admin kullanıcıları ise tüm kullanıcıları yönetebilir ve fatura bilgilerini ekleyebilir/düzenleyebilir.
 •	Yetkilendirme için Authorize attribute'ları kullanılır ve her endpoint'e uygun roller atanır.
#### Veritabanı
•	Veritabanı, Apartment, User, Bill ve Message tablolarını içerir.
•	Veritabanı modeli, DbContext sınıfında yapılandırılır ve entity ilişkileri burada tanımlanır.

## Geliştirici
Bu projenin geliştiricisi: Funda Yıldırımkaraman

