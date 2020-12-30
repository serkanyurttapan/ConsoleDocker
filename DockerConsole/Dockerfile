#base image yüklüyorum. microdoft kendisi oluþturuyor. sitesinden aldým.
#https://hub.docker.com/_/microsoft-dotnet-runtime

FROM mcr.microsoft.com/dotnet/core/runtime:3.1
#image içerisinde dosya(katman) oluþturacak komutu yazýyorum.
#WORKDIR:çalýþma klasörüdür.
#App demek =>image içerisinde app klasörü oluþacak.
WORKDIR /app
#ve app içerisinde oluþturucaðým klasörü oluþturuyorum. bu dosyayý atmak için copy komutu kullanýyorum
# aþaðýdaki dosya yolunu App klasörüne kopyaladým.
COPY bin/Release/netcoreapp3.1/publish /app/
#ENTRYPOINT:bir image dan bir container ayaða kalktýðýnda çalýþacak olan kodu(.dll) belirtir.

ENTRYPOINT ["dotnet","DockerConsole.dll"]

#docker build yapmam için docker build -t dockerconsoleapp ile ayaða kaldýrmam gerekir.(böylelikle image oluþur.)
#docker images ile docker üzerinde image lerimi listeler.

# docker da container oluþturmam için; docker create --name dockerconsole container yazdým
#containerleri görmek için; docker ps -a (aþaðýdaki komutu yazdýktan sonra status ü exited olarak gelecektir.)
#container cçalýþtýrmak için; docker start dockerconsole_container yazdým. port numarasý boþ olarak gelir. console uygulaasý olduðundan dolayý.

 #var olan containerleri durdurmak için; docker stop dockerconsole_container
 #var olan uygulamaya baðlanmak için docker attach kullanýlýr.
 
 #Faydalý komut satýrlar DockerCLI
 # 1-) Run: docker create ve docker start komutlarýnýn ikisini birden yaparak projeyi ayaða kaldýrýr.(container oluþturup ayaða kaldýrýr.)
 #örneðin; docker run --name consolecontainer3(containeradý) 4a1( boþluk image ýd nin ilk 3 karakter kullanýlsa da olur.)
 #2-) docker rm  consoleappcontainer4(container adý veya ID nin ilk 3 harfi)ise containiri siler
 #docker rmi consoleappimage(image adý) komutu ile ise imageler silinir.
 # docker da çalýþan container i silmek için öncelikle containeri durdurmam lazým
 #çalýþan docker,   docker rm container-id/name --force  yazýlýrsa durdurman gerek hatasý alýnmadan silme iþlemini gerçekleþtirebilirim. fakat imagelarda direkt force parametresi kullanarak silemem(aslýnda bir önlem alýyor docker) öncesinde containerin durmasý lazým durmuþ haldeyse image silinir.
 # containeri ayaða kaldýrdýktan sonra projeyi çalýþtýrmak için;
 #docker run --name container(veya ID) image(veya ID)
 
 #3-) docker pull
 #Bu komutla beraber docker hub sitesinden istenilen image local docker a çekilebilir.
 # 4-) docker push ile docker hub a oluþturduðum repository e gönderilecektir.

 #not: sdk ile runtime arasýndaki fark; sdk içerisinde uygulama gelitirilebilir. runtime ise uygulamayý çalýþtýrabilecek ortam oluþur(publish edilmiþ dosya varsa).
 # linux image kullanma sebebimiz daha hafif image oluþturmasýndan dolayýdýr. zaten cross platform olacaðýndan dolayý (.net core) linux sectim.
 # core mvc uygulamasý sadece windows da çalýþýr. o yüzden sadece windows imageleri çekmem lazýmdý


 # -Pusj yapma adýmlarý;
 # 1- docker pull busybox indirdim (busybox UNIX komutlarýnýn çalýþtýrýlmasýný saðlayan bir uygulamadýr. ve diskten kazanç saðlar)
 # 2- docker tag busybox 597194/console_repository(docker hub da oluþturduðum repository adý ve version ekleyerek locate oldum)
 # 3- docker push 597194/dockercoreconsole:v1 olarak en son pushladým