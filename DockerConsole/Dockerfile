#base image y�kl�yorum. microdoft kendisi olu�turuyor. sitesinden ald�m.
#https://hub.docker.com/_/microsoft-dotnet-runtime

FROM mcr.microsoft.com/dotnet/core/runtime:3.1
#image i�erisinde dosya(katman) olu�turacak komutu yaz�yorum.
#WORKDIR:�al��ma klas�r�d�r.
#App demek =>image i�erisinde app klas�r� olu�acak.
WORKDIR /app
#ve app i�erisinde olu�turuca��m klas�r� olu�turuyorum. bu dosyay� atmak i�in copy komutu kullan�yorum
# a�a��daki dosya yolunu App klas�r�ne kopyalad�m.
COPY bin/Release/netcoreapp3.1/publish /app/
#ENTRYPOINT:bir image dan bir container aya�a kalkt���nda �al��acak olan kodu(.dll) belirtir.

ENTRYPOINT ["dotnet","DockerConsole.dll"]

#docker build yapmam i�in docker build -t dockerconsoleapp ile aya�a kald�rmam gerekir.(b�ylelikle image olu�ur.)
#docker images ile docker �zerinde image lerimi listeler.

# docker da container olu�turmam i�in; docker create --name dockerconsole container yazd�m
#containerleri g�rmek i�in; docker ps -a (a�a��daki komutu yazd�ktan sonra status � exited olarak gelecektir.)
#container c�al��t�rmak i�in; docker start dockerconsole_container yazd�m. port numaras� bo� olarak gelir. console uygulaas� oldu�undan dolay�.

 #var olan containerleri durdurmak i�in; docker stop dockerconsole_container
 #var olan uygulamaya ba�lanmak i�in docker attach kullan�l�r.
 
 #Faydal� komut sat�rlar DockerCLI
 # 1-) Run: docker create ve docker start komutlar�n�n ikisini birden yaparak projeyi aya�a kald�r�r.(container olu�turup aya�a kald�r�r.)
 #�rne�in; docker run --name consolecontainer3(containerad�) 4a1( bo�luk image �d nin ilk 3 karakter kullan�lsa da olur.)
 #2-) docker rm  consoleappcontainer4(container ad� veya ID nin ilk 3 harfi)ise containiri siler
 #docker rmi consoleappimage(image ad�) komutu ile ise imageler silinir.
 # docker da �al��an container i silmek i�in �ncelikle containeri durdurmam laz�m
 #�al��an docker,   docker rm container-id/name --force  yaz�l�rsa durdurman gerek hatas� al�nmadan silme i�lemini ger�ekle�tirebilirim. fakat imagelarda direkt force parametresi kullanarak silemem(asl�nda bir �nlem al�yor docker) �ncesinde containerin durmas� laz�m durmu� haldeyse image silinir.
 # containeri aya�a kald�rd�ktan sonra projeyi �al��t�rmak i�in;
 #docker run --name container(veya ID) image(veya ID)
 
 #3-) docker pull
 #Bu komutla beraber docker hub sitesinden istenilen image local docker a �ekilebilir.
 # 4-) docker push ile docker hub a olu�turdu�um repository e g�nderilecektir.

 #not: sdk ile runtime aras�ndaki fark; sdk i�erisinde uygulama gelitirilebilir. runtime ise uygulamay� �al��t�rabilecek ortam olu�ur(publish edilmi� dosya varsa).
 # linux image kullanma sebebimiz daha hafif image olu�turmas�ndan dolay�d�r. zaten cross platform olaca��ndan dolay� (.net core) linux sectim.
 # core mvc uygulamas� sadece windows da �al���r. o y�zden sadece windows imageleri �ekmem laz�md�


 # -Pusj yapma ad�mlar�;
 # 1- docker pull busybox indirdim (busybox UNIX komutlar�n�n �al��t�r�lmas�n� sa�layan bir uygulamad�r. ve diskten kazan� sa�lar)
 # 2- docker tag busybox 597194/console_repository(docker hub da olu�turdu�um repository ad� ve version ekleyerek locate oldum)
 # 3- docker push 597194/dockercoreconsole:v1 olarak en son pushlad�m