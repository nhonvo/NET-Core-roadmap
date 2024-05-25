#!/bin/sh
NAME="awslocal"
echo "configure $NAME!"
awslocal dynamodb create-table --table-name AppTable --attribute-definitions AttributeName=Id,AttributeType=S --key-schema AttributeName=Id,KeyType=HASH --billing-mode PAY_PER_REQUEST