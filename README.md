# F# Mutable Variables and References Bug

This repository demonstrates a subtle issue related to mutable variables and references in F#.  The `swap` function appears to work correctly when used with mutable variables but fails when used with references.

## Bug Description
The `swap` function is intended to swap the values of two variables. When used with mutable variables, it functions as expected. However, when used with references, it does not modify the original values referenced by `x2` and `y2`. This is because the function operates on copies of the values contained within the references, not the references themselves.

## Solution
The solution involves modifying the `swap2` function to directly manipulate the references using the `:=` operator.