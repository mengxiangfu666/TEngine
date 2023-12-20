@echo off

echo ******StopRedis Begin ******

tasklist | find "redis-server.exe"
if %errorlevel%==0 ( 
    echo stopRedis
	ping -n 3 127.0.0.1>nul
    taskkill /im redis-server.exe /f
    ping -n 3 127.0.0.1>nul
) 

echo ******StopRedis Finsh ******




