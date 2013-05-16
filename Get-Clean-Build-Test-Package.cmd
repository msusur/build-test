git clone git://github.com/msusur/build-test.git
cd build-test
build.cmd
cd ..
DEL build-test\*.* /S /q
rd build-test