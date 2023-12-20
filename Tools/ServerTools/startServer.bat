@echo off

call stopServer.bat
call startRedis.bat
echo ******StartServer Begin ******

set JDK11Path= "JDK11Path"
set ServerJarPath= "ServerJarPath"

for /f "tokens=1,2 delims==" %%i in (conf.ini) do (
    if %%i==JDK11Path set JDK11Path=%%j
    if %%i==ServerJarPath set ServerJarPath=%%j
    )
start %JDK11Path%\scjava.exe -jar %ServerJarPath%

echo ******StartServer Finsh ******



