# Azure Setup Commands

Run these commands to create your Azure Web App:

```bash
# Login to Azure
az login

# Create resource group
az group create --name rg-cli-webapp --location "East US"

# Create App Service plan
az appservice plan create --name myappserviceplan --resource-group rg-cli-webapp --sku B1

# Create Web App
az webapp create --resource-group rg-cli-webapp --plan myappserviceplan --name mywebapp-cli-check --runtime "DOTNETCORE|8.0"
```

## 2. Get Publish Profile:

```bash
# Download publish profile
az webapp deployment list-publishing-profiles --name mywebapp-cli-check --resource-group rg-cli-webapp --xml
```

## 3. Add GitHub Secret:

1. Go to your GitHub repo: https://github.com/harrye900/simple-dot-net-appservice
2. Go to Settings > Secrets and variables > Actions
3. Click "New repository secret"
4. Name: `AZUREAPPSERVICE_PUBLISHPROFILE`
5. Value: Paste the entire XML content from step 2