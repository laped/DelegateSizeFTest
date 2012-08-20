XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch
PROJECT_ROOT=/Users/lbp/Projects/github/DelegateSizeFTest/DelegateTestLibrary
PROJECT=$(PROJECT_ROOT)/DelegateTestLibrary.xcodeproj
TARGET=DelegateTestLibrary

all: TestBinding.dll

libTestBinding-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libTestBinding-armv6.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv6 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libTestBinding-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libTestBindingSDK.a: libTestBinding-i386.a libTestBinding-armv6.a libTestBinding-armv7.a
	lipo -create -output $@ $^

TestBinding.dll: ApiDefinition.cs StructsAndEnums.cs AssemblyInfo.cs libTestBindingSDK.a
	$(BTOUCH) -e ApiDefinition.cs StructsAndEnums.cs AssemblyInfo.cs --out=$@ --link-with=libTestBindingSDK.a,libTestBindingSDK.a

clean: 
	-rm -f *.a *.dll
