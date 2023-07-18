# Product's title: Buy-a-feature app

- Introduction: Product's Purpose

- Description: User Needs

- Features: Functional Requirements

## Product's Purpose

This is a mini project for a new intern to test his development skills. The goal is to give the intern a real life experience in software product creation.

###### Definitions and Acronyms

- Unit = a virtual currency to be used against a feature.

- PM = Product Manager

## User Needs

A group of PMs can distribute "unit" values for each listed feature for a given product. This app should enable the "buy-a-product" approach when trying to prioritizing a list of items.

## Functional Requirements: Stage 1

- An application that displays a grid of entries.

- The list in the grid must be fed/read from a `.csv` file, selected by the user.

- Required fields/columns expected from the file are: title; description. If they do not appear in the file, a visual warning must be provided.

- The grid should show addtional columns: Entry id; one or more users;

- Column - Entry id: if provided in the file, fill the entry with it; else create an automated value

- Column - user: identified in the file as `user:[name]`. If no such column exists in the file, create a default column in the grid for the user.

- User name should appear on the top of the column; it must be editable.

- If the file has addtional columns they can be ommitted from the grid

- Save file automatically when the application closes. It overrides the previous file. Note, do not delete any of the un-used additoinal columns from the file. -> TODO!!

## Functional Requirements: Stage 2

- Ability to add a new row/entry -> Done

- Ability to edit an existing row (any of the fields) -> Done

- Column - user: it can only accept integer numbers; No less than `0` and not more than `100`. Block the user from adding any other value. -> TODO

- Ability to delete a row. -> DONE

## Functional Requirements: Stage 3

- Add one final column which takes the average of the users' values in the `user` column. -> Added col just will do cals

- Ability to change the sort of the rows by any of the columns. -> TODO

- Save unto the file with the selected sorted column. -> TODO

- Add more users (user column). -> TOASK
