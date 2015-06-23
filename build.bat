@powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"
.dnx\bin\dnvm install latest -Unstable -Persistent
%userprofile%\.dnx\runtimes\dnx*\bin\dnu restore
%userprofile%\.dnx\runtimes\dnx*\bin\dnu build --configuration Release
%userprofile%\.dnx\runtimes\dnx*\bin\dnx . test