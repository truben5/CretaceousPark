Welcome to Cretaceous Park

Getting Started:
    1. Make sure that you have Git installed on your machine
    2. Go to the gitlab page and click on Project Overview on the left hand side
    3. Go to top right and click on blue Clone button. Copy the url for clone with https
    4. Open Command Window and navigate to directory you wish to store this project. Enter in Command Window: git clone <copied-url>
    5. Enter in Command Window: git checkout -b <FirstName_LastName>
    6. Enter in command Window: git push --set-upstream origin <FirstName_LastName>
    
    This should create your branch of the project and update GitLab with it
    
Saving Work:
    1. Open Command Window and navigate to directory with project in it. 
    2. Enter in Command Window: git add .
    3. Enter in Command Window: git commit -m <Message for commit>
    4. Enter in Command Window: git push
    
Submitting Finished Work:
    1. Go to gitlab page and click on merge requests at the left hand side and click new merge request
    2. On the source branch side of select your branch for submission and for the target branch select master. Click compare branches and continue
    3. Review differences between branches to make sure it is correct.
    4. Submit merge request