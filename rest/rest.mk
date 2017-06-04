##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Release
ProjectName            :=rest
ConfigurationName      :=Release
WorkspacePath          :=/home/ibroheem/usr/devs/cpp/lib/POCO
ProjectPath            :=/media/60128FC5128F9EA2/usr/devs/cpp/lib/POCO/rest
IntermediateDirectory  :=./Release
OutDir                 := $(IntermediateDirectory)
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Ibroheem
Date                   :=01/02/17
CodeLitePath           :=/home/ibroheem/.codelite
LinkerName             :=g++-4.9
SharedObjectLinkerName :=g++-4.9 -shared -fPIC
ObjectSuffix           :=.o
DependSuffix           :=.o.d
PreprocessSuffix       :=.o.i
DebugSwitch            :=-gstab
IncludeSwitch          :=-I
LibrarySwitch          :=-l
OutputSwitch           :=-o 
LibraryPathSwitch      :=-L
PreprocessorSwitch     :=-D
SourceSwitch           :=-c 
OutputFile             :=$(IntermediateDirectory)/$(ProjectName)
Preprocessors          :=$(PreprocessorSwitch)NDEBUG 
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E 
ObjectsFileList        :="rest.txt"
PCHCompileFlags        :=
MakeDirCommand         :=mkdir -p
LinkOptions            :=  -lPocoFoundation -lPocoNet -lPocoUtil -s /home/ibroheem/usr/local/lib/libfmt.a
IncludePath            := $(IncludeSwitch)/home/ibroheem/usr/include $(IncludeSwitch)/home/ibroheem/usr/local/include  $(IncludeSwitch). $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := 
ArLibs                 :=  
LibPath                :=$(LibraryPathSwitch)/home/ibroheem/usr/lib $(LibraryPathSwitch)/usr/local/ssl/lib $(LibraryPathSwitch)/usr/local/lib $(LibraryPathSwitch)/home/ibroheem/usr/local/lib  $(LibraryPathSwitch). 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := ar rcus
CXX      := g++-4.9
CC       := gcc-4.9
CXXFLAGS := -D _GLIBCXX_USE_CXX11_ABI=0 -O2 -std=c++14 -Wall $(Preprocessors)
CFLAGS   :=  -O2 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := as


##
## User defined environment variables
##
CodeLiteDir:=/usr/share/codelite
Objects0=$(IntermediateDirectory)/server.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: $(OutputFile)

$(OutputFile): $(IntermediateDirectory)/.d $(Objects) 
	@$(MakeDirCommand) $(@D)
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@test -d ./Release || $(MakeDirCommand) ./Release


$(IntermediateDirectory)/.d:
	@test -d ./Release || $(MakeDirCommand) ./Release

PreBuild:


##
## Objects
##
$(IntermediateDirectory)/server.cpp$(ObjectSuffix): server.cpp $(IntermediateDirectory)/server.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/media/60128FC5128F9EA2/usr/devs/cpp/lib/POCO/rest/server.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/server.cpp$(ObjectSuffix) $(IncludePath)
$(IntermediateDirectory)/server.cpp$(DependSuffix): server.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT$(IntermediateDirectory)/server.cpp$(ObjectSuffix) -MF$(IntermediateDirectory)/server.cpp$(DependSuffix) -MM server.cpp

$(IntermediateDirectory)/server.cpp$(PreprocessSuffix): server.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) $(IntermediateDirectory)/server.cpp$(PreprocessSuffix)server.cpp


-include $(IntermediateDirectory)/*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r ./Release/


