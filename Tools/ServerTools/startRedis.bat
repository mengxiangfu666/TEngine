@echo off

echo ******StartRedis Begin ******

set RedisPath= "RedisPath"

for /f "tokens=1,2 delims==" %%i in (conf.ini) do (
    if %%i==RedisPath set RedisPath=%%j
    )

start %RedisPath%\redis-server.exe %RedisPath%\redis.windows.conf

echo ******StartRedis Finsh ******



