#base image yüklüyorum. microdoft kendisi oluþturuyor. sitesinden aldým.
#https://hub.docker.com/_/microsoft-dotnet-runtime

FROM mcr.microsoft.com/dotnet/runtime:3.1
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