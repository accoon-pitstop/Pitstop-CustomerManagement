#!/bin/bash
DOCKER_TAG='latest'
docker login -u $DOCKER_USERNAME -p $DOCKER_PASSWORD
docker build -t dshop.services.customers:$DOCKER_TAG .
docker tag dshop.services.customers:$DOCKER_TAG $DOCKER_USERNAME/dshop.services.customers:$DOCKER_TAG
docker push $DOCKER_USERNAME/dshop.services.customers:$DOCKER_TAG