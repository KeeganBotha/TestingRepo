using System;
using Xunit;

namespace GradeBook.Test
{
	public class TypeTests
	{
		[Fact]
		public void StringsBehaveLikeValueTypes()
		{
			//arrange
			string name = "Scott";
			var upper = MakeUppercase(name);

			//act

			//assert
			Assert.Equal("Scott", name);
			Assert.Equal("SCOTT", upper);
		}

		private string MakeUppercase(string name)
		{
			return name.ToUpper();
		}

		[Fact]
		public void ValueTypesAlsoPassedByValue()
		{
			//arrange
			var x = GetInt();
			SetInt(ref x);

			//act

			//assert
			Assert.Equal(42, x);
		}

		private void SetInt(ref int x)
		{
			x = 42;
		}

		int GetInt()
		{
			return 3;
		}

		[Fact]
		public void CSharpCanPassByRef()
		{
			//arrange
			var book1 = GetBook("Book 1");

			//act
			GetBookSetNamebyRef(ref book1, "New Name");

			//assert
			Assert.Equal("New Name", book1.Name);
		}

		[Fact]
		public void CSharpIsPassByValue()
		{
			//arrange
			var book1 = GetBook("Book 1");

			//act
			GetBookSetName(book1, "New Name");

			//assert
			Assert.Equal("Book 1", book1.Name);
		}

		[Fact]
		public void CanSetNameFromReference()
		{
			//arrange
			var book1 = GetBook("Book 1");
			//act
			SetName(book1, "New Name");

			//assert
			Assert.Equal("New Name", book1.Name);
		}

		[Fact]
		public void GetBookReturnsDifferentObjects()
		{
			//arrange
			var book1 = GetBook("Book 1");
			var book2 = GetBook("Book 2");
			//act


			//assert
			Assert.Equal("Book 1", book1.Name);
			Assert.Equal("Book 2", book2.Name);
		}

		[Fact]
		public void TwoVariablesCanReferenceTheSameObject()
		{
			//arrange
			var book1 = GetBook("Book 1");
			var book2 = book1;
			//act


			//assert
			Assert.Equal("Book 1", book1.Name);
			Assert.Equal("Book 1", book2.Name);
			Assert.Same(book1, book2);
			Assert.True(object.ReferenceEquals(book1, book2));
		}

		Book GetBook(string name)
		{
			return new Book(name);
		}

		private void SetName(Book book, string name)
		{
			book.Name = name;
		}

		private void GetBookSetName(Book book, string name)
		{
			book = new Book(name);
		}

		private void GetBookSetNamebyRef(ref Book book, string name)
		{
			book = new Book(name);
		}
	}
}
