#!/bin/bash
# env vars
message="Env vars... "
echo $message

DEV="/home/dev/webs/dog"  # dog == DevOps Genie
WEBUI = ${DEV}+"/webui"
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

# DevOpsGenie WebUI

message="Moving WebUI ..."
echo $message

# create dir(s)
mkdir ${DEV}
mkdir ${WEBUI}
mkdir ${WEBUI}/src

# move src
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/src/*.* ${WEBUI}/src

# move files
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.css ${WEBUI}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.js ${WEBUI}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.html ${WEBUI}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.json ${WEBUI}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/packages.config ${WEBUI}/*.*
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.css ${WEBUI}/*.*


echo "done."

