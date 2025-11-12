# Azure Setup Commands

Run these commands to create your Azure Web App:

```bash
# Login to Azure
az login

# Create resource group
az group create --name myResourceGroup --location "East US"

# Create App Service plan
az appservice plan create --name myAppServicePlan --resource-group myResourceGroup --sku FREE

# Create Web App (replace 'harrye900-simple-webapp' with your unique name)
az webapp create --resource-group myResourceGroup --plan myAppServicePlan --name harrye900-simple-webapp --runtime "DOTNETCORE|8.0"
```

## 2. Get Publish Profile:

```bash
# Download publish profile
az webapp deployment list-publishing-profiles --name harrye900-simple-webapp --resource-group myResourceGroup --xml
```

## 3. Add GitHub Secret:

1. Go to your GitHub repo: https://github.com/harrye900/simple-dot-net-appservice
2. Go to Settings > Secrets and variables > Actions
3. Click "New repository secret"
4. Name: `AZUREAPPSERVICE_PUBLISHPROFILE`
5. Value: Paste the entire XML content from step 2