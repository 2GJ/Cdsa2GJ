//An onboarding process requires applicants to take some medical test.
//The test are parametrized and must be iterated to get the ones that apply for each case.
FilterDocs = "ApplicantRole =" + <Request.Applicant.ApplicantRole> + " and Required= " + true;
Tests = Me.getXPath("entity-list('MedicalTest','"+FilterDocs+"')");
for(Counter=0; Counter < Tests.size(); Counter++)
{
Test = Me.addRelation("Request.Applicant.ApplicantTests");
Test.setXPath("MedicalTestName",Tests[Counter].getXPath("Id"));
Test.setXPath("Required",true);
}


//In a Purchase Request process each request has many products
//We throw a validation if there are products that are not approved
if(<exists(Request.Products[Approved = false])>)
{
CHelper.ThrowValidationError("There are products not approved");
}


  //Some comments are registered in an activity. They have to be included
//in a collection of comments as history information
Comment = <Request.Comment>;
User = Me.Case.WorkingCredential.UserId;
CommentRecord=Me.newCollectionItem("Request.CommentHistory")
CommentRecord.setXPath("Comments",Comment);
CommentRecord.setXPath("User",User);