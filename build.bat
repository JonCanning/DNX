@powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"
.dnx\bin\dnvm install latest -Unstable -Persistent
pushd %cd%
cd %userprofile%\.dnx\runtimes\dnx*\bin\dnu
set path=%path%;%cd%
popd
echo %path%
dnu restore
dnu build --configuration Release
dnx . test