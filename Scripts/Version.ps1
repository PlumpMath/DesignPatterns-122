$global:var1 = $null
$tfsRev = [int]((get-date).TimeOfDay.TotalMinutes * 20)
$year = get-date -UFormat %y
$juliandate = $year + ((get-date).dayofyear).ToString("000")
$baseBuildNumber = "4.1610"

	$buildNumber = $baseBuildNumber + "." + $juliandate + ".$tfsRev"
	$var1 = $buildNumber
	write-output $var1