#!/bin/bash

dir="$(dirname "$(realpath "$0")")"

cd $dir

ls -R | grep ":$" | sed -e 's/:$//' -e 's/[^-][^\/]*\//--/g' -e 's/^/   /' -e 's/-/|/'
