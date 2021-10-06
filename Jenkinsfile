
import java.text.*

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
                 def versionString = "devops1."+BUILD_NUMBER
                
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
             stage('Restore Packages')
            {   
                dir('EFileDiagnostics//Service')                
                 {
                     bat 'dotnet restore TRTA.Diagnostics.RuleEngine.sln'
                 } 
            }

        
            stage('Build & Publish')
            { 
                dir('EFileDiagnostics//Service')                
                   {
                       bat 'dotnet publish TRTA.Diagnostics.RuleEngine.sln'
                   } 
            }
            
           stage('Zip Publish')
            {
              zip archive: true, dir: 'EFileDiagnostics/Service/src/TRTA.Diagnostics.RuleEngine.Service/bin/Debug/netcoreapp2.1/publish/', glob: '', zipFile: "publish.zip"
                
            }
            
           stage('Deploy to lambda function') 
            {
                  withCredentials([[
                                     $class: 'AmazonWebServicesCredentialsBinding', 
                                     accessKeyVariable: 'AWS_ACCESS_KEY_ID', 
                                     credentialsId: 'AWS_LOCAL', 
                                     secretKeyVariable: 'AWS_SECRET_ACCESS_KEY'
                                  ]]) 
                    {
                       
                        // bat 'aws lambda update-function-code --function-name arn:aws:lambda:us-east-1:306592655528:function:a200205-brms-dev-apitester  --region us-east-1 --zip-file fileb://"publish.zip"'
          
                        bat'aws lambda update-function-configuration --function-name arn:aws:lambda:us-east-1:306592655528:function:a200205-brms-dev-apitester --environment Variables={Serilog__Properties__DisableSecurity=F,Serilog__Properties__GoSystemsSecurityUrl=T}'
                    }
            }        
                    
  
			 
        }
    }
}
catch (e)
{
    echo e.getMessage()
    currentBuild.result = 'FAILURE'
    throw e
}
