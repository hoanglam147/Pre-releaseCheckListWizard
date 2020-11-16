echo "# Pre-releaseCheckListWizard" >> README.md
git init
git add *
git commit -m "second commit"
git branch -M main
git remote add origin https://github.com/hoanglam147/Pre-releaseCheckListWizard.git
git push -u origin main