// JScript File

	myPage = self.location;	thisPage = top.location;if (thisPage == myPage)		{			contentSRC = escape(myPage);			frameURL = 'index.html?' + contentSRC;			top.location.href = frameURL;		}