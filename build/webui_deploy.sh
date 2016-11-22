#!/bin/bash   DevOpsGenie webui deploy
# env vars
message="Env vars... "
echo $message

DEV="/home/dev/webs/dog/webui"  # dog == DevOps Genie
message="DEV: "
message+=$DEV
echo $message

JENKINS_HOME="/var/lib/jenkins"
message="JENKINS_HOME: "
message+=$JENKINS_HOME
echo $message

# nuke everything under DEV
echo "Nuke everything ... but not node_modules"
rm -rfv $DEV
# re-create dev/webs dir
mkdir $DEV

# DevOpsGenie WebUI

message="Moving WebUI ..."
echo $message

# create dir(s)
mkdir $DEV
mkdir $DEV/src

# move src
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/src/*.* ${DEV}/WebUI/src

# move files
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.css ${DEV}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.js ${DEV}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.html ${DEV}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.json ${DEV}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/packages.config ${DEV}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.css ${DEV}/*.*


echo "done."

