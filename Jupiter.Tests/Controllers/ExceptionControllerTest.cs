using Jupiter.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using Jupiter.Repository;

namespace Jupiter.Tests.Controllers
{
    
    
    /// <summary>
    ///이 클래스는 ExceptionControllerTest에 대한 테스트 클래스로서
    ///ExceptionControllerTest 단위 테스트를 모두 포함합니다.
    ///</summary>
    [TestClass()]
    public class ExceptionControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///현재 테스트 실행에 대한 정보 및 기능을
        ///제공하는 테스트 컨텍스트를 가져오거나 설정합니다.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 추가 테스트 특성
        // 
        //테스트를 작성할 때 다음 추가 특성을 사용할 수 있습니다.
        //
        //ClassInitialize를 사용하여 클래스의 첫 번째 테스트를 실행하기 전에 코드를 실행합니다.
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup을 사용하여 클래스의 테스트를 모두 실행한 후에 코드를 실행합니다.
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize를 사용하여 각 테스트를 실행하기 전에 코드를 실행합니다.
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup을 사용하여 각 테스트를 실행한 후에 코드를 실행합니다.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///ExceptionController 생성자 테스트
        ///</summary>
        // TODO: UrlToTest 특성이 ASP.NET 페이지에 대한 URL을 지정하는지 확인하십시오(예:
        // http://.../Default.aspx). 페이지, 웹 서비스 또는 WCF 서비스를 테스트할 경우
        // 단위 테스트를 웹 서버에서 실행하려면 이 작업을 수행해야 합니다.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Project\\MS\\Jupiter\\Jupiter", "/")]
        [UrlToTest("http://localhost:6821/")]
        public void ExceptionControllerConstructorTest()
        {
            ExceptionController target = new ExceptionController();
            Assert.Inconclusive("TODO: 대상을 확인하는 코드를 구현합니다.");
        }

        /// <summary>
        ///Details 테스트
        ///</summary>
        // TODO: UrlToTest 특성이 ASP.NET 페이지에 대한 URL을 지정하는지 확인하십시오(예:
        // http://.../Default.aspx). 페이지, 웹 서비스 또는 WCF 서비스를 테스트할 경우
        // 단위 테스트를 웹 서버에서 실행하려면 이 작업을 수행해야 합니다.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Project\\MS\\Jupiter\\Jupiter", "/")]
        [UrlToTest("http://localhost:6821/")]
        public void DetailsTest()
        {
            ExceptionController target = new ExceptionController(); // TODO: 적절한 값으로 초기화합니다.
            long id = 0; // TODO: 적절한 값으로 초기화합니다.
            ViewResult expected = null; // TODO: 적절한 값으로 초기화합니다.
            ViewResult actual;
            actual = target.Details(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("이 테스트 메서드의 정확성을 확인합니다.");
        }

        /// <summary>
        ///ExceptionHandleCreate 테스트
        ///</summary>
        // TODO: UrlToTest 특성이 ASP.NET 페이지에 대한 URL을 지정하는지 확인하십시오(예:
        // http://.../Default.aspx). 페이지, 웹 서비스 또는 WCF 서비스를 테스트할 경우
        // 단위 테스트를 웹 서버에서 실행하려면 이 작업을 수행해야 합니다.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Project\\MS\\Jupiter\\Jupiter", "/")]
        [UrlToTest("http://localhost:6821/")]
        public void ExceptionHandleCreateTest()
        {
            ExceptionController target = new ExceptionController(); // TODO: 적절한 값으로 초기화합니다.
            long id = 0; // TODO: 적절한 값으로 초기화합니다.
            ViewResult expected = null; // TODO: 적절한 값으로 초기화합니다.
            ViewResult actual;
            actual = target.ExceptionHandleCreate(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("이 테스트 메서드의 정확성을 확인합니다.");
        }

        /// <summary>
        ///ExceptionHandleList 테스트
        ///</summary>
        // TODO: UrlToTest 특성이 ASP.NET 페이지에 대한 URL을 지정하는지 확인하십시오(예:
        // http://.../Default.aspx). 페이지, 웹 서비스 또는 WCF 서비스를 테스트할 경우
        // 단위 테스트를 웹 서버에서 실행하려면 이 작업을 수행해야 합니다.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Project\\MS\\Jupiter\\Jupiter", "/")]
        [UrlToTest("http://localhost:6821/")]
        public void ExceptionHandleListTest()
        {
            ExceptionController target = new ExceptionController(); // TODO: 적절한 값으로 초기화합니다.
            long id = 0; // TODO: 적절한 값으로 초기화합니다.
            ViewResult expected = null; // TODO: 적절한 값으로 초기화합니다.
            ViewResult actual;
            actual = target.ExceptionHandleList(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("이 테스트 메서드의 정확성을 확인합니다.");
        }

        /// <summary>
        ///Index 테스트
        ///</summary>
        // TODO: UrlToTest 특성이 ASP.NET 페이지에 대한 URL을 지정하는지 확인하십시오(예:
        // http://.../Default.aspx). 페이지, 웹 서비스 또는 WCF 서비스를 테스트할 경우
        // 단위 테스트를 웹 서버에서 실행하려면 이 작업을 수행해야 합니다.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Project\\MS\\Jupiter\\Jupiter", "/")]
        [UrlToTest("http://localhost:6821/")]
        public void IndexTest()
        {
            ExceptionController target = new ExceptionController(); // TODO: 적절한 값으로 초기화합니다.
            Nullable<int> page = new Nullable<int>(); // TODO: 적절한 값으로 초기화합니다.
            Nullable<int> pageSize = new Nullable<int>(); // TODO: 적절한 값으로 초기화합니다.
            ViewResult expected = null; // TODO: 적절한 값으로 초기화합니다.
            ViewResult actual;
            actual = target.Index(page, pageSize);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("이 테스트 메서드의 정확성을 확인합니다.");
        }
    }
}
