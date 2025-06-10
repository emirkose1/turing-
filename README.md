## PIN Doğrulama Turing Makinesi Simülasyonu

## Proje Açıklaması
Bu proje, Turing makinesi mantığını kullanarak basit bir PIN doğrulama sistemi simüle etmektedir.  
Kullanıcıdan 4 haneli PIN kodu alınır ve sabit olarak tanımlı sistem PIN’iyle karşılaştırılır.  
Karakterler tek tek kontrol edilir ve eşleşen karakterler, Turing makinesindeki bant mantığına uygun olarak işaretlenir (`X` ve `Y` karakterleri ile).  
Tüm karakterler eşleşirse, PIN doğru kabul edilir; aksi takdirde reddedilir.

## Çalışma Prensibi
Program, kullanıcıdan 4 haneli PIN ister.
`#` sembolleri ile ayrılmış şekilde bir bant (string) oluşturulur:  
`#KULLANICI_PIN#SISTEM_PIN#`
Program, bu bant üzerinden karakter karakter ilerleyerek kullanıcı PIN’i ile sistem PIN’ini karşılaştırır.
Her eşleşen karakter kullanıcı için `X`, sistem için `Y` ile işaretlenir.

Eğer karakterler arasında fark bulunursa, işlem durur ve şifre reddedilir.
Tüm karakterler eşleşirse, şifre kabul edilir.

## Çıktı Örnekleri 
![Ekran görüntüsü 2025-06-10 181715](https://github.com/user-attachments/assets/68e2c922-47ba-442e-aa41-4b9aaada2778)

![Ekran görüntüsü 2025-06-10 181758](https://github.com/user-attachments/assets/21c0e733-2f72-46bd-a338-123718eb8758)

![Ekran görüntüsü 2025-06-10 181813](https://github.com/user-attachments/assets/4d140032-dea9-4d2b-97a1-e23fd5ef23be)
