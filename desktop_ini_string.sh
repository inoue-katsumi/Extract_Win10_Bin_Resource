#!/bin/bash
# Scan all "desktop.ini" file under C:\Users and print out resource string.
# ExtractData.exe source is https://github.com/inoue-katsumi/Extract_Win10_Bin_Resource/blob/master/ExtractData.cs
find /mnt/c/Users/ -name "desktop.ini" 2>/dev/null |
while read dtini
do
	echo "= = $dtini = =";
	(cat "$dtini"; iconv -f utf-16 -t utf-8 "$dtini" 2>/dev/null) |
		sed -rn 's/^.*system32\\([^\]+),-(.*)$/\1 \2/p' |
		while read line
		do
			./ExtractData.exe $line
			# Line below prints out aliased(alternative) path
			#./ExtractData.exe $line | sed -nr "s|(.*)|$(echo $dtini|sed -r 's|[^/]+/desktop.ini$||')\1|p"
		done
done
