# Minikube with Local Helm Chart

[![GitHub stars](https://img.shields.io/github/stars/Ealenn/Minikube-Local-Helm-Chart?style=for-the-badge)](https://github.com/Ealenn/Minikube-Local-Helm-Chart/stargazers) [![GitHub issues](https://img.shields.io/github/issues/Ealenn/Minikube-Local-Helm-Chart?style=for-the-badge)](https://github.com/Ealenn/Minikube-Local-Helm-Chart/issues) [![GitHub license](https://img.shields.io/github/license/Ealenn/Minikube-Local-Helm-Chart?style=for-the-badge)](https://github.com/Ealenn/Minikube-Local-Helm-Chart)

## Requirements

- Docker
- Kubernetes CLI
- Helm CLI
- Minikube

## Run Minikube

```bash
minikube start
kubectl config use-context minikube
```

## Deployment

Set environment variables to dictate that docker should run a command against Minikube machine.

```sh
eval $(minikube docker-env)
```

Build your image

```sh
docker build . -f ./src/Minikube.Local.Helm.Chart.WebApplication/Dockerfile -t ealen.minikube.webapplication:latest
```

Deploy your app

```sh
helm upgrade -i webapp ./charts/minikube-helm-webapp --force
```

Use port forward 

```sh
kubectl port-forward deployment/wepapp 8080:80
```

Go to http://127.0.0.1:8080 


That's all folk !