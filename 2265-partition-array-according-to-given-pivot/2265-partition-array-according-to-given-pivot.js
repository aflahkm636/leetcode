/**
 * @param {number[]} nums
 * @param {number} pivot
 * @return {number[]}
 */
var pivotArray = function(nums, pivot) {
            let lessThanPivot=[],Pivot=[],greaterThanPivot=[]
    for(x of nums)
    {
        if (x<pivot) lessThanPivot.push(x)
        else if(x==pivot)Pivot.push(x)
        else greaterThanPivot.push(x)
    }
    return [...lessThanPivot,...Pivot,...greaterThanPivot]
};