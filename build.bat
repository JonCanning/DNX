@powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"
%userprofile%\.dnx\bin\dnvm install latest -Unstable -Persistent
rem pushd %cd%
rem cd %userprofile%\.dnx\runtimes\dnx*\bin
rem set path=%path%;%cd%
rem popd
dnu restore
dnu build --configuration Release
dnx . test