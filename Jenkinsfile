import java.text.*
def Version = null
def FileName = null
def enableDeploy = 'true'
// Build Properties (num builds to keep, polling, blocking, etc)
properties([buildDiscarder(logRotator(artifactDaysToKeepStr: '30', artifactNumToKeepStr: '5', daysToKeepStr: '30', numToKeepStr: '5'))])

try
{
    timestamps
    {
        node('master')
        {
            stage('Set Version')
            {
                 def dateFormat = new SimpleDateFormat("yyyy.MM.dd")
                 def date = new Date()
                 def dateString = dateFormat.format(date)
                 def versionString = BRANCH_NAME+'.'+BUILD_NUMBER
                
                 currentBuild.displayName = versionString
             
                
            }

            //pull the source code from git tfs.
            stage('check out')
            {
                // delete the existing source code to cleanup the workspace.
                deleteDir()
                // checkout the code from git tfs to the workspace.
                checkout scm
            }
            stage('Build Project')
            {    catchError(buildResult: 'SUCCESS', stageResult: 'FAILURE') 
                             {
                                   dir('EFileDiagnostics//Service')                
                                   {
                                       bat 'dotnet restore TRTA.Diagnostics.RuleEngine.sln'
                                   } 
                             }
                  echo "Coming out from Building stage"                

            }
            stage('Send Out Notifications')
             {     echo"Total URL - > "+"$BUILD_URL"

                   echo "Sending to darvebhat@gmail.com............"
                      
                   echo "Done"
            }
            
        }
    }
}
catch (e){
    echo e.getMessage()
    currentBuild.result = 'FAILURE'
    throw e
}