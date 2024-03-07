node {
    def app
    parameters {
        choice(name: "ENVIRONMENT", choices: ["test", "production"], description: "Choose Environment")
    }
    stage ('Clean workspace') {
        cleanWs()
    }
    
    stage ('Git Checkout') {
      
      git branch: 'main', credentialsId: '74ef8903-9236-47e4-b8ad-79f7e24157ed', url: 'https://github.com/rynSoft/productionApi.git'
      
    }
    
    stage('Remove Existing Image') {
        sh('docker image rmi udea-${ENVIRONMENT}-be || (echo "Image udea-${ENVIRONMENT}-be didn\'t exist so not removed."; exit 0)')
    }
      
    stage('Build image') {
        sh('docker build -t udea-${ENVIRONMENT}-be . --no-cache')
    }
    
    stage('Save Tar File') {
        if (params.ENVIRONMENT == 'production')
        {
            sh('docker save udea-${ENVIRONMENT}-be > udea-${ENVIRONMENT}-be.tar')
        }
    } 
    
    stage('Remove Existing Container') {
        if (params.ENVIRONMENT == 'test')
        {
            sh('docker rm -f udea-${ENVIRONMENT}-be')
        }
    }
    
    stage('Deploy to Test') {
        if (params.ENVIRONMENT == 'test')
        {
            sh('docker run -d --restart unless-stopped -e ASPNETCORE_ENVIRONMENT=${ENVIRONMENT} -p 8021:80 --name udea-${ENVIRONMENT}-be udea-${ENVIRONMENT}-be')
        }
    }  

}
