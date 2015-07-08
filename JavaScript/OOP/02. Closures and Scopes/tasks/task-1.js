function solve() {
	var library = (function () {
		var books = [],
			categories = [],
			errors = {
				MissingBookProperty : function(){
					throw new Error('All book properties must be defined');
				},
				NotUniqueTitleError : function(title){
					throw new Error('Book with title ' + title + 'already exist in the library');
				},
				NotValidTitleError : function(){
					throw new Error('Title must be between 2 and 100 characters long.');
				},
				NotValidAuthorError : function(){
					throw new Error('Author name cannot be an empty string');
				},
				NotValidISBN : function(){
					throw new Error('ISBN must be 10 or 13 digits and containing only digits');
				},
				NotValidCategoryError : function(){
					throw new Error('Category must be between 2 and 100 characters long');
				}
			};

		function checkAllBookProperties(book){
			if('title' in book &&
				'author' in book &&
				'isbn' in book &&
				'category' in book){
				return true;
			}
			else{
				return false;
			}
		}

		function isValidAuthor(name){
			var len = name.length;
			if(len < 1){
				return false;
			}
			else{
				return true;
			}
		}

		function isValidTitle(title){
			var len = title.length;
			if(len < 2 || len > 100){
				return false;
			}
			else{
				return true;
			}
		}

		function isValidISBN(isbn){
			var len = isbn.length,
				i;
			for(i = 0; i < len; i += 1){
				if(isNaN(isbn[i] * 1)){
					return false;
				}
			}
			if(len !== 13 && len !== 10){
				return false;
			}
			if(isNotUniqueProperty(isbn, 'isbn')){
				return false;
			}

			return true;
		}

		function isNotUniqueProperty(name, type){
			var i,
				len = books.length;
			for(i = 0; i < len; i += 1){
				if(books[i][type] === name){
					return true;
				}
			}
			return false;
		}

		function isValidCategory(category){
		}

		function categoryExists(category){
			if(categories.indexOf(category) < 0){
				return false;
			}
			else{
				return true;
			}
		}

		function addBook(book) {
			if(!checkAllBookProperties(book)){
				errors.MissingBookProperty();
			}
			if(!isValidTitle(book.title)){
				errors.NotValidTitleError(book.title);
			}
			if(isNotUniqueProperty(book.title, 'title')){
				errors.NotUniqueTitleError();
			}
			if(!isValidAuthor(book.author)){
				errors.NotValidAuthorError(book.author);
			}
			if(!isValidISBN(book.isbn)){
				errors.NotValidISBN();
			}
			if(!isValidTitle(book.category)){
				errors.NotValidCategoryError();
			}
			book.ID = books.length + 1; 
            books.push(book);
            if(!categoryExists(book.category)){
            	categories.push(book.category);
            }
            return book;
		}

		function listBooks(option) {
			var listedBooks = [];
			if(option && option.author){
				listedBooks = books.filter(function (book){
					return book.author === option.author;
				});
			}
			else if(option && option.category){
				listedBooks = books.filter(function (book){
					return book.category === option.category;
				});
			}
			else{
				listedBooks = books;
			}

			listedBooks = listedBooks.sort(function (Book1, Book2) {
				return Book1.ID - Book2.ID;
			});

			return listedBooks;
		}

		function listCategories() {
			categories = categories.sort(function (firstCategory, secondCategory) {
                return firstCategory - secondCategory;
            });
            return categories;
		}
		
		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
//solve();
