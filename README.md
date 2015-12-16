# PublishTwoSitesInCloudService

Sample project showing how to host two Web project on single machine in Azure Cloud Service. 

# How to deploy

1. Checkout this repo
2. Change Cloud Service project -> Webrole1 setting Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString to valid Storage Account key. 
3. Right click on Cloud Service project -> Package -> ok with defeult settings
4. Package was created in PublishTwoSitesInCloudService\PublishTwoSitesInCloudService\csx\Release
4. Go to Azure portal. Create new Cloud Service with created created package and config file. 

Verify Cloud Service creaded only one virtual machine, but you can open diferent applications both at port 80 and 8080.

Reference:

[https://michaelcollier.wordpress.com/2013/01/14/multiple-sites-in-a-web-role/](https://michaelcollier.wordpress.com/2013/01/14/multiple-sites-in-a-web-role/)
[http://www.wadewegner.com/2011/02/running-multiple-websites-in-a-windows-azure-web-role/](https://michaelcollier.wordpress.com/2013/01/14/multiple-sites-in-a-web-role/)
