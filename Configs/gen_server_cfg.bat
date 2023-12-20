set GEN_JAR=../tool/perfect_gen.jar
set CSV_DIR=..\cfg

java -cp %GEN_JAR% perfect.gen.cfg.Main -xml %CSV_DIR%\cfg_sc.xml -c gen\cfg -g server -l java -d .\config

pause
