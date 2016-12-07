#!/bin/bash
# env vars
message="Env vars... "
echo $message

DEV="/home/dev/webs/dog"  # dog == DevOps Genie


# DevOpsGenie WebUI

WEBUI="/home/dev/webs/dog/webui"

message="WEBUI: "
message+= WEBUI
echo $message

JENKINS_HOME="/var/lib/jenkins"
message="JENKINS_HOME: "
message+=$JENKINS_HOME
echo $message

# nuke everything under DEV
echo "clean out root web files"
rm $WEBUI/*.*

# move root web files
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.css ${WEBUI}
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.js ${WEBUI}
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.html ${WEBUI}
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.json ${WEBUI}
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/packages.config ${WEBUI}
cp $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/*.css ${WEBUI}

# move src
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/src ${WEBUI}/src

# move css, img, js, less, sass, vendor files from Greyscale Backbone template
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/css ${WEBUI}/css
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/img ${WEBUI}/img
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/js ${WEBUI}/js
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/less ${WEBUI}/less
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/sass ${WEBUI}/sass
cp -TRv $JENKINS_HOME/jobs/DevOpsGenie/workspace/WebUI/vendor ${WEBUI}/vendor
echo "done."

