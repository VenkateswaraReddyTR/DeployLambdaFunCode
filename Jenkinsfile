@Library('shared-jenkins') _
import java.text.SimpleDateFormat
def Version = null
def FileName = null
def enableDeploy = 'true'
// Build Properties (num builds to keep, polling, blocking, etc)
properties([buildDiscarder(logRotator(artifactDaysToKeepStr: '30', artifactNumToKeepStr: '5', daysToKeepStr: '30', numToKeepStr: '5'))])

try
{
    timestamps
    {
        node('brmsnode')
        {
            stage('Set Version')
            {
                //Setting the version based on the branch type
                def dateFormat = new SimpleDateFormat("MM.dd")
                def date = new Date()
                def dateString = dateFormat.format(date)
                def trimCharacters = null
                def versionString = null
                def prefix = ''
                currentBuild.result = 'SUCCESS'
                
                switch(BRANCH_NAME)
                {
                    case ~/develop/:
                        trimCharacters = 'develop/'
                        versionString = dateString+'.${BUILD_NUMBER}'
                        prefix = BRANCH_NAME
                        break;
                    case ~/devops/:
                        trimCharacters = 'devops/'
                        versionString = dateString+'.${BUILD_NUMBER}'
                        prefix = BRANCH_NAME
                        break;
                    default:
                        trimCharacters = ''
                        versionString = '${BUILD_MONTH}.${BUILD_DAY}.${BUILD_NUMBER}'
                        prefix = ""
                        break;
                }
                //prefix = powershell returnStdout: true, script: "\"${prefix}\".trim('${trimCharacters}/')"
                //prefix = prefix.trim()
                Version = VersionNumber versionNumberString: "$versionString", versionPrefix: "$prefix."
                FileName = VersionNumber versionNumberString: "$versionString", versionPrefix: ""
                //The display name needs to always be the version, the deployment jobs depend on this, so don't change it.
                currentBuild.displayName = Version
            }

            //pull the source code from git tfs.
            stage('check out')
            {
                // delete the existing source code to cleanup the workspace.
                deleteDir()

                // checkout the code from git tfs to the workspace.
                checkout scm
            }
            stage('.Net Restore')
            {
                 dir('EFileDiagnostics//Service')
                {
                    bat 'dotnet restore TRTA.Diagnostics.RuleEngine.sln'
                } 

            }
            stage('Build')
            {
                dir('EFileDiagnostics//Service')
                {
                    bat 'dotnet build TRTA.Diagnostics.RuleEngine.sln'
                }
            }
            def MSTestParam = tool 'VSTestTools_MSTest'
            def zipFileName="$FileName"+".zip"
            // stage('Unit Tests')
            // {
                
            // }
            stage('zipping artifacts')
            {
                //zipping artifacts
                zip dir: 'EFileDiagnostics/Service/src/TRTA.Diagnostics.RuleEngine.Service/bin/Debug/netcoreapp2.1/', glob: '', zipFile: zipFileName

                // // create a Version folder
                // powershell "New-Item -Path $WORKSPACE\\$Version -ItemType directory"

                // //pushing zip into Version folder
                // powershell "Copy-Item -Path $WORKSPACE\\*.zip $WORKSPACE\\$Version"
            }
 }
    }
}
catch (e){
    echo e.getMessage()
    currentBuild.result = 'FAILURE'
    throw e
}