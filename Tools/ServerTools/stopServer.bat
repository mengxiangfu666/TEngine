@echo off

echo ******StopServer Begin ******

tasklist | find "scjava.exe"
if %errorlevel%==0 ( 
    echo stopServer
    ping -n 3 127.0.0.1>nul
    taskkill /im scjava.exe /f
) 

echo ******StopServer Finsh ******
call stopRedis.bat


