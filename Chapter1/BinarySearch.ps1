################################################
# Function: PowerShell Binary Search Algorithm #
################################################
#
function BinarySearch
{
   Param ([int[]]$YourOrderedArray, $ItemSearched)
   [int] $LowIndex = 0
   [int] $HigIndex = $YourOrderedArray.Length - 1
   while ($LowIndex -le $HigIndex)
       {
#        [int]$script:MiddlePoint = ($LowIndex + $HigIndex) / 2
         [int]$script:MiddlePoint = $LowIndex + (($HigIndex - $LowIndex) / 2)
         $InspectedValue = $YourOrderedArray[$script:MiddlePoint].YourObjectSearched
         If ($InspectedValue -lt $ItemSearched)
             {
                $LowIndex = $script:MiddlePoint + 1
             }
         Elseif ($InspectedValue -gt $ItemSearched)
             {
                $HigIndex = $script:MiddlePoint - 1
             }
         Else
             {
                $script:ItemFound = $True
                return
             }
      }
    $script:ItemFound = $False
    $script:MiddlePoint = -($LowIndex + 1)
    return
}

[int[]] $My_OrderedArray=1,2,3,4,5,6,7,8,9,10 # Example

Write-Host $(BinarySearch($My_OrderedArray, 3))
Write-Host $(BinarySearch($My_OrderedArray, -1))