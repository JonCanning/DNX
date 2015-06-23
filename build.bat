@powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"
cmd /c %userprofile%\.dnx\bin\dnvm install latest -Unstable -Persistent
pushd %cd%
cd %userprofile%\.dnx\runtimes\dnx*\bin
set path=%path%;%cd%
popd
cmd /c dnu restore
cmd /c dnu build Api --configuration Release
cmd /c dnu build Tests --configuration Release
cmd /c dnx Tests test