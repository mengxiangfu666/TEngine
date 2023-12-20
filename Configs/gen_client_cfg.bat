SET JAVA_HOME=%cd%\..\Tools\Luban\JDK10
SET Classpath=%JAVA_HOME%\lib\tools.jar;%JAVA_HOME%\lib\dt.jar;
SET Path=%JAVA_HOME%\bin;

set GEN_JAR=../Tools/Luban/perfect_gen.jar

set CSharp_DIR=../UnityProject/Assets/GameScripts/HotFix/GameProto/GameConfig
set Data_DIR=../UnityProject/Assets/AssetRaw/Configs/bytes

java -Xms1g -cp %GEN_JAR% perfect.gen.cfg.Main -xml ./cfg_sc.xml -e %CSharp_DIR% -g editor -d %Data_DIR% -l cs -sl 1

pause
