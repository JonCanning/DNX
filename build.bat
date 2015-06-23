@powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"dnx\bin\dnvm install latest -Unstable -Persistent
rem pushd %cd%
dir %userprofile%\.dnx\runtimes\*.*
rem cd %userprofile%\.dnx\runtimes\dnx*\bin
rem set path=%path%;%cd%
rem popd
rem dnu restore
rem dnu build --configuration Release
rem dnx . test