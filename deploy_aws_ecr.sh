aws login
aws ecr get-login-password --region us-east-1 | docker login --username AWS --password-stdin 568279883407.dkr.ecr.us-east-1.amazonaws.com
docker build -t kamal-foods-server .
docker tag kamal-foods-server:latest 568279883407.dkr.ecr.us-east-1.amazonaws.com/kamal-foods-server:latest
docker push 568279883407.dkr.ecr.us-east-1.amazonaws.com/kamal-foods-server:latest